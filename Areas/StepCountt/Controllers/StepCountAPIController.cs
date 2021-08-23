using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartWatch.Areas.StepCountt.Models;
using SmartWatch.DbModels;

namespace SmartWatch.Areas.StepCountt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StepCountAPIController : ControllerBase
    {
        public int PostAsync()
        {
            Microsoft.AspNetCore.Http.HttpContext context = Request.HttpContext;


            StepCountAPIRequest req = new StepCountAPIRequest();

            //  req.DeviceId = Convert.ToInt32(context.Request.Form["DeviceId"]);
            req.DeviceCode = context.Request.Form["DeviceCode"];
            req.StepCount = Convert.ToInt64(context.Request.Form["StepCount"]);
            req.DiviceTime = Convert.ToDateTime(context.Request.Form["DiviceTime"]);

            using (SmartWatchContext db = new SmartWatchContext())
            {
                var devzassign = db.DeviceAssigns.Join(
                   db.Devices.Where(w => w.DeviceCode == req.DeviceCode),
                  deviceassg => deviceassg.DeviceId,
                  dvice => dvice.DeviceId,
                  (deviceassg, dvice) => new { DeviceAssign = deviceassg, Device = dvice }
                   ).OrderBy(w => w.DeviceAssign.ConnectNo).LastOrDefault();


                if (devzassign != null)
                {
                    StepCount stpcount = new StepCount()
                    {
                        ConnectionId = null,
                        UserId = devzassign.DeviceAssign.UserId,
                        Steps = req.StepCount,
                        DeviceTime = req.DiviceTime,
                        Timestamp = DateTime.UtcNow,
                    };
                    db.StepCounts.Add(stpcount);
                }
                db.SaveChanges();

            }

                return 0;
        }

    }
}
