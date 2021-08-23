using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartWatch.DbModels;

namespace SmartWatch.Areas.Alerts.Controllers
{
    [Route("api/Alerts/[controller]")]
    [ApiController]
    public class NurseHasSeenController : ControllerBase
    {
        [HttpPut]
        [Route("[action]")]
        public bool SetNurseHasSeen(NurseHasSeenReq req)
        { 
            using (SmartWatchContext db = new SmartWatchContext())
            {
                HealthAlert dbhealthalert = db.HealthAlerts.Where(w => w.UserId == req.UserId && w.TriggerId == req.TriggerId).FirstOrDefault();
                if (dbhealthalert == null)
                {
                    return false;
                }
                dbhealthalert.HasSeen = req.HasSeen;
                dbhealthalert.Response = req.Response;
                db.SaveChanges();
            }
            return true;
        }
    }

    public class NurseHasSeenReq
    {
        public int UserId { get; set; }
        public long TriggerId { get; set; }
        public bool HasSeen { get; set; }
        public string Response { get; set; }

    }
}
