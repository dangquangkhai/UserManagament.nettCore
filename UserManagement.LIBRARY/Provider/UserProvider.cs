using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using UserManagement.LIBRARY.Model;
using UserManagement.LIBRARY.Provider;
using UserManagement.LIBRARY.EncryptLib;

namespace UserManagement.LIBRARY.Provider
{
    public class UserProvider : BaseProvider
    {
        public List<User> getAllUsr()
        {
            try
            {
                return base.db.User.ToList();
            }
            catch (Exception ex)
            {
                return new List<User>();
            }
        }

        public User getUsrByEmail(String Email)
        {
            try
            {
                return base.db.User.Where(u => u.Email == Email).FirstOrDefault();
            }
            catch (Exception)
            {
                return new User();
            }
        }

        public Boolean addUser(User usr, ref Exception _ex)
        {
            try
            {
                usr.Password = HashStr.SHA1Hash(usr.Password);
                base.db.User.Add(usr);
                base.db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                _ex = ex;
                return false;
            }

        }

        public Boolean editUser(int UsrId, User usr, ref Exception _ex)
        {
            try
            {
                User qr = base.db.User.Where(u => u.Id == UsrId).FirstOrDefault();
                if (qr == null)
                {
                    throw new Exception("Not found user");
                }
                qr.Email = (String.IsNullOrEmpty(usr.Email)) ? (qr.Email) : (usr.Email);
                qr.Username = (String.IsNullOrEmpty(usr.Username)) ? (qr.Username) : (usr.Username);
                qr.Firstname = (String.IsNullOrEmpty(usr.Firstname)) ? (qr.Firstname) : (usr.Firstname);
                qr.Lastname = (String.IsNullOrEmpty(usr.Lastname)) ? (qr.Lastname) : (usr.Lastname);
                qr.Password = (String.IsNullOrEmpty(usr.Password)) ? (qr.Password) : (HashStr.SHA1Hash(usr.Password));
                qr.Ssn = usr.Ssn;
                qr.Birthday = usr.Birthday;
                qr.IsEnabled = usr.IsEnabled;
                qr.Phone = usr.Phone;
                qr.Image = usr.Image;
                qr.Address = usr.Address;
                base.db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                _ex = ex;
                return false;
            }
        }


    }
}