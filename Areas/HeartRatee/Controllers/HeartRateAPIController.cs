using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartWatch.Areas.HeartRatee.Models;
using SmartWatch.DbModels;

namespace SmartWatch.Areas.HeartRatee.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class HeartRateAPIController : ControllerBase
    {
        public int PostAsync()
        {
              
            Microsoft.AspNetCore.Http.HttpContext context = Request.HttpContext;

            HeartRateAPIRequest req = new HeartRateAPIRequest();
            req.DeviceCode = context.Request.Form["DeviceCode"];
            req.HeartRate = Convert.ToDouble(context.Request.Form["HeartRate"]);
            req.DiviceTime = Convert.ToDateTime(context.Request.Form["DiviceTime"]);


            using (SmartWatchContext db = new SmartWatchContext())
            {
                var dassgn = db.DeviceAssigns.Join(
                    db.Devices.Where(w => w.DeviceCode == req.DeviceCode),
                    deviass => deviass.DeviceId,
                    device => device.DeviceId,
                    (deviass, device) => new { DeviceAssign = deviass, Devices = device }
                    ).OrderBy(w => w.DeviceAssign.ConnectNo).LastOrDefault();
               
                if (dassgn != null)
                {
                    HeartRate heartRate = new HeartRate()
                    {
                        ConnectionId = null,
                        UserId = dassgn.DeviceAssign.UserId,
                        PulseRate = req.HeartRate,
                        DeviceTime = req.DiviceTime,
                        CheckedTime = DateTime.UtcNow,
                    };
                    db.HeartRates.Add(heartRate);
                }
                db.SaveChanges();
            }
            return 0;
        }
    }
}
