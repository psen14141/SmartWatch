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
    public class NurseFixedController : ControllerBase
    {
        [HttpPut]
        [Route("[action]")]
        public bool SetNurseFixed(NurseFixedReq req)
        {         
            using (SmartWatchContext db = new SmartWatchContext())
            {
                HealthAlert dbhealthalert = db.HealthAlerts.Where(w => w.UserId == req.UserId && w.TriggerId == req.TriggerId).FirstOrDefault();
                if (dbhealthalert == null)
                {
                    return false;
                }
                dbhealthalert.GotAction = req.GotAction;
                dbhealthalert.HasSeen = true;
                dbhealthalert.Alertseentime = DateTime.Now;
                db.SaveChanges();
            }
            return true;
        }
    }

    public class NurseFixedReq 
    {
        public int UserId { get; set; }
        public long TriggerId { get; set; }
        public bool GotAction { get; set; }
        public DateTime? Alertseentime { get; set; }

    }
}
