using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartWatch.Areas.SimulatorAPI.Models;
using SmartWatch.DbModels;

namespace SmartWatch.Areas.SimulatorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SimulatorValueAPIController : ControllerBase
    {
        public int PostAsync()
        {
            Microsoft.AspNetCore.Http.HttpContext context = Request.HttpContext;

            SimulatorAPIRequest req = new SimulatorAPIRequest();

           // req.DeviceId = Convert.ToInt32(context.Request.Form["DeviceId"]);
            req.DeviceCode = context.Request.Form["DeviceCode"];
            req.StepCount = Convert.ToInt64(context.Request.Form["StepCount"]);
            req.DiviceTime = Convert.ToDateTime(context.Request.Form["DiviceTime"]);
            req.Temperature = Convert.ToDouble(context.Request.Form["Temperature"]);
            req.BloodPressureLower = Convert.ToDouble(context.Request.Form["BloodPressureLower"]);
            req.BloodPressureUpper = Convert.ToDouble(context.Request.Form["BloodPressureUpper"]);
            req.PulseRate = Convert.ToDouble(context.Request.Form["PulseRate"]);

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

                    BodyTemperature bodytemp = new BodyTemperature()
                    {
                        ConnectId = null,
                        UserId = devzassign.DeviceAssign.UserId,
                        Temperature = req.Temperature,
                        DeviceTime = req.DiviceTime,
                        CheckedTimestamp = DateTime.UtcNow,
                    };
                    db.BodyTemperatures.Add(bodytemp);

                    HeartRate heartRate = new HeartRate()
                    {
                        ConnectionId = null,
                        UserId = devzassign.DeviceAssign.UserId,
                        PulseRate = req.PulseRate,
                        DeviceTime = req.DiviceTime,
                        CheckedTime = DateTime.UtcNow,
                    };
                    db.HeartRates.Add(heartRate);


                    BloodPressure bloodPressure = new BloodPressure()
                    {
                        ConnectionId = null,
                        UserId = devzassign.DeviceAssign.UserId,
                        BloodPressureUpper = req.BloodPressureUpper,
                        BloodPreesureLower = req.BloodPressureLower,
                        DeviceTime = req.DiviceTime,
                        Checkedtime = DateTime.UtcNow,

                    };
                    db.BloodPressures.Add(bloodPressure);
             
                }
                db.SaveChanges();

            }




            return 0;
        }
    }
}
