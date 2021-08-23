using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartWatch.Areas.BdyTemperature.Models;
using SmartWatch.DbModels;

namespace SmartWatch.Areas.BdyTemperature.Conrollers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BodyTemperatureAPIController : ControllerBase
    {

        public int PostAsync()
        {
            Microsoft.AspNetCore.Http.HttpContext context = Request.HttpContext;


            BodyTemperatureAPIRequest req = new BodyTemperatureAPIRequest();

            req.DeviceCode = context.Request.Form["DeviceCode"];
            // req.DeviceId = Convert.ToInt32(context.Request.Form["DeviceId"]);
            req.Temperature = Convert.ToDouble(context.Request.Form["Temperature"]);
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
                    BodyTemperature bodytemp = new BodyTemperature()
                    {
                        ConnectId = null,
                        UserId = devzassign.DeviceAssign.UserId,
                        Temperature = req.Temperature,
                        DeviceTime = req.DiviceTime,
                        CheckedTimestamp = DateTime.UtcNow,
                    };
                    db.BodyTemperatures.Add(bodytemp);
                }
                db.SaveChanges();

            }

            return 0;
        }


    }
}
