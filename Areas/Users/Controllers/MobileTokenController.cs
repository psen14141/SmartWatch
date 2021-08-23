using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartWatch.DbModels;

namespace SmartWatch.Areas.Users.Controllers
{
    [Route("api/Users/[controller]")]
    [ApiController]
    public class MobileTokenController : ControllerBase
    {

        [HttpPut]
        [Route("[action]")]
        public bool SetMobileToken(MobileTokenReq req)
        {
            if (req.Token == string.Empty)
            {
                return false;
            }
            using (SmartWatchContext db = new SmartWatchContext())
            {
                User dbuser = db.Users.Where(w => w.Email == req.Email).FirstOrDefault();
                if (dbuser == null)
                {
                    return false;
                }
                dbuser.Mobiledevicetoken = req.Token;
                db.SaveChanges();
            }
            return true;
        }
    }

    public class MobileTokenReq
    {
        public string Token { get; set; }
        public string Email { get; set; }

    }
}
