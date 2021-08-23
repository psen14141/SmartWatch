using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SmartWatch.DbModels;
using SmartWatch.ProPlatform.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartWatch.Areas.Users.Controllers
{
    [Area("Users")]
    public class TokenWebController : Controller
    {
        public IActionResult SetWebToken(string token)
        {
            int userId = 1;//Convert.ToInt32(HttpContext.Session.GetString(SessionKeys.UserId));
            if (token == string.Empty)
            {
                return Json(false);
            }
            using (SmartWatchContext db = new SmartWatchContext())
            {
                User dbuser = db.Users.Where(w => w.UserId == userId).FirstOrDefault();
                if (dbuser == null)
                {
                    return Json(false);
                }
                dbuser.Webapplicationtoken = token;
                db.SaveChanges();
            }
            return Json(true);

        }
    }
}
