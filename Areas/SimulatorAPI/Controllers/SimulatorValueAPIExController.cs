using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartWatch.DbModels;
using SmartWatch.Areas.SimulatorAPI.Models;

namespace SmartWatch.Areas.SimulatorAPI.Controllers
{
    
    [ApiController]
    [Area("SimulatorAPI")]
    [Route("api/SimulatorAPI/[controller]")]
    public class SimulatorValueAPIExController : ControllerBase
    {

        [HttpPost]
        public APIResponce PostAsync(SimulatorAPIRequest req)
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

                // var dassgn = db.DeviceAssigns.Where(w => w.DeviceId == req.DeviceId).OrderBy(w => w.ConnectNo).LastOrDefault();
                if (devzassign != null)
                {

                    StepCount stpcount = new StepCount()
                    {
                        ConnectionId = devzassign.DeviceAssign.ConnectNo,
                        UserId = devzassign.DeviceAssign.UserId,
                        Steps = req.StepCount,
                        DeviceTime = req.DiviceTime,
                        Timestamp = DateTime.UtcNow,
                    };
                    db.StepCounts.Add(stpcount);

                    BodyTemperature bodytemp = new BodyTemperature()
                    {
                        ConnectId = devzassign.DeviceAssign.ConnectNo,
                        UserId = devzassign.DeviceAssign.UserId,
                        Temperature = req.Temperature,
                        DeviceTime = req.DiviceTime,
                        CheckedTimestamp = DateTime.UtcNow,
                    };
                    db.BodyTemperatures.Add(bodytemp);


                    HeartRate heartRate = new HeartRate()
                    {
                        ConnectionId = devzassign.DeviceAssign.ConnectNo,
                        UserId = devzassign.DeviceAssign.UserId,
                        PulseRate = req.PulseRate,
                        DeviceTime = req.DiviceTime,
                        CheckedTime = DateTime.UtcNow,
                    };
                    db.HeartRates.Add(heartRate);


                    BloodPressure bloodPressure = new BloodPressure()
                    {
                        ConnectionId = devzassign.DeviceAssign.ConnectNo,
                        UserId = devzassign.DeviceAssign.UserId,
                        BloodPressureUpper = req.BloodPressureUpper,
                        BloodPreesureLower = req.BloodPressureLower,
                        DeviceTime = req.DiviceTime,
                        Checkedtime = DateTime.UtcNow,

                    };
                    db.BloodPressures.Add(bloodPressure);

                }
                db.SaveChanges();
              //  checktemprure(req);
                
            }


            APIResponce aPIResponce = new APIResponce();
            aPIResponce.IsChangeWaiting = true;
            aPIResponce.WaitingTime  = 1000;
                return aPIResponce;



        }

        //public int checktemprure(SimulatorAPIRequest req)
        //{
        //    Microsoft.AspNetCore.Http.HttpContext context = Request.HttpContext;

        //    using (SmartWatchContext db = new SmartWatchContext())
        //    {


        //        var devzassign = db.DeviceAssigns.Join(
        //           db.Devices.Where(w => w.DeviceCode == req.DeviceCode),
        //          deviceassg => deviceassg.DeviceId,
        //          dvice => dvice.DeviceId,
        //          (deviceassg, dvice) => new { DeviceAssign = deviceassg, Device = dvice }
        //           );

        //        var uconfig = devzassign.Join(
        //            db.UserConfigurations,
        //            dvs => dvs.DeviceAssign.UserId,
        //            uconf => uconf.UserId,
        //            (dvs, uconf) => new { DeviceAssign = dvs, UserConfiguration = uconf }
        //           );
        //        userconfigurationViewModel userconfigurationViewModel = new userconfigurationViewModel();
        //        foreach (var item in uconfig)
        //        {
        //            userconfigurationViewModel.UserId = item.UserConfiguration.UserId;
        //            userconfigurationViewModel.ConfigurationId = item.UserConfiguration.ConfigurationId;
        //            userconfigurationViewModel.Value = item.UserConfiguration.Value;

        //        }
        //        decimal dt = Convert.ToDecimal(req.Temperature);
        //        if (dt > userconfigurationViewModel.Value)
        //        {
        //            // hiiii
        //        }
        //        else
        //        {


        //        }

        //    }

        //    return 0;
        //}



    }

    public class APIResponce
    {
        public int WaitingTime { get; set; } = 2000;
        public bool IsChangeWaiting { get; set; } = false;

        public int ResultCode { get; set; } = 0;
    }
}
