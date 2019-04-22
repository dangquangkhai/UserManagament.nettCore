using UserManagement.LIBRARY.Model;
using UserManagement.LIBRARY.Provider;
using System.Web;

namespace UserManagement.LIBRARY
{
    public class SessionHelper
    {
        protected static User _CurrentUser = new User();
        // public static User CurrentUser 
        // {
        //     get {
        //         string companyEmail = HttpContext.Current.User.Identity.Name;
        //         if (string.IsNullOrEmpty(companyEmail))
        //         {
        //             User anonymousUser = new User();
        //             anonymousUser.Id = -1;
        //             anonymousUser.Firstname = "Vô";
        //             anonymousUser.Lastname = "Danh";
        //             return anonymousUser;
        //         }
        //          UserProvider user = new UserProvider();

        //         return user.getUsrByEmail(companyEmail);
        //     }
        //     set {
        //         _CurrentUser = value;
        //     }
        // }
    }
}
