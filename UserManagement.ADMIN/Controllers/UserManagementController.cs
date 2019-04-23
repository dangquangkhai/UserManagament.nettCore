using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserManagement.LIBRARY;
using UserManagement.LIBRARY.Model;
using UserManagement.LIBRARY.Provider;

namespace UserManagement.ADMIN.Controllers
{
    public class UserManagementController : Controller
    {
        private UserProvider _provider = new UserProvider();
        public IActionResult Index()
        {
            return View();
        }
        
        public JsonResult GetAllUsr()
        {
            try
            {
                Dictionary<Object, Object> obj = new Dictionary<object, object>();
                List <User> lstUsr = _provider.getAllUsr();
                for(int i = 0; i < lstUsr.Count(); i++)
                {
                    lstUsr[i].Password = null;
                }
                obj.Add("success", true);
                obj.Add("content", ReflectionHelper.ListModelToLstObject(lstUsr));
                return Json(obj);
            }
            catch (Exception ex)
            {
                Dictionary<Object, Object> obj = new Dictionary<object, object>();
                obj.Add("success", false);
                obj.Add("content", ex.Message.ToString());
                return Json(obj);
            }
        }
        
        [HttpGet]
        public IActionResult AddUser()
        {
            return View();
        }
    }
}