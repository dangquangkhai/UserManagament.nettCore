using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using UserManagement.LIBRARY.Model;
using UserManagement.LIBRARY.Provider;

namespace UserManagement.LIBRARY.Provider
{
    public class UserProvider : BaseProvider
    {
        public List<User> getAllUsr()
        {
            try
            {
                return base.db.User.ToList();
            } catch(Exception ex)
            {
                return new List<User>();
            }
        }

        public User getUsrByEmail(String Email)
        {
            try
            {
                return base.db.User.Where(u => u.Email == Email).FirstOrDefault();
            }catch(Exception )
            {
                return new User();
            }
        }

    }
}