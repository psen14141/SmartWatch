using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using SmartWatch.DbModels;
using SmartWatch.ProPlatform.FileManager;
using SmartWatch.ProPlatform.Security;
using Microsoft.AspNetCore.Http;

namespace GloableCommunication.Areas.Users.Controllers
{
    [Area("Users")]
    public class UserController : Controller
    {

        public IActionResult Login(LoginRequest request)
        {

            string encPassword = ProEncryptor.ToMD5Hash(request.Password);
            using ( SmartWatchContext db = new SmartWatchContext())
            {
                var user = db.Users.Where(w => w.Email.Trim() == request.UserId && w.Password.Trim() == encPassword).FirstOrDefault();
                if (user != null)
                {
                    HttpContext.Session.SetString(SessionKeys.UserId, user.UserId.ToString().Trim());
                    //long instituteId = db.InstuteUserType.Where(w => w.InstituteUserTypeId == user.InstituteUserTypeId).First().InsituteId;
                    //HttpContext.Session.SetString(SessionKeys.OrgId, instituteId.ToString());
                    return Redirect("/");
                }
            }
            return Redirect("/Users/User/LoginView");
        }

        public IActionResult LoginView()
        {
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return Redirect("/");
        }
    }
    public class LoginRequest
    {
        public string UserId { get; set; }
        public string Password { get; set; }
    }
}
