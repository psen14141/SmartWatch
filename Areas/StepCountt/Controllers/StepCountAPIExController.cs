using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using SmartWatch.DbModels;
using System.Linq;
using System.Threading.Tasks;
using SmartWatch.Areas.StepCountt.Models;

namespace SmartWatch.Areas.StepCountt.Controllers
{
    [Area("StepCountt")]
    [Route("api/StepCountt/[controller]")]
    [ApiController]


    public class StepCountAPIExController : ControllerBase
    {

        [HttpPost]
        public APIResponce PostAsync(StepCountAPIRequest req)
        {
            Microsoft.AspNetCore.Http.HttpContext context = Request.HttpContext;

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
                    StepCount stepcunt = new StepCount()
                    {
                        ConnectionId = devzassign.DeviceAssign.ConnectNo,
                        UserId = devzassign.DeviceAssign.UserId,
                        Steps = req.StepCount,
                        DeviceTime = req.DiviceTime,
                        Timestamp = DateTime.UtcNow,
                    };

                    db.StepCounts.Add(stepcunt);
                }
                db.SaveChanges();
            }
            APIResponce aPIResponce = new APIResponce();
            aPIResponce.IsChangeWaiting = true;
            aPIResponce.WaitingTime = 1000;
            return aPIResponce;

        }

        public class APIResponce
        {
            public int WaitingTime { get; set; } = 2000;
            public bool IsChangeWaiting { get; set; } = false;

            public int ResultCode { get; set; } = 0;
        }
    }
}