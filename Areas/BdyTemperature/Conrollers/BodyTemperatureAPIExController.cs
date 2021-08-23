using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartWatch.DbModels;
using System.Net;
using System.Net.Http;
using SmartWatch.Areas.BdyTemperature.Models;
using System.Collections;

namespace SmartWatch.Areas.BdyTemperature.Conrollers
{

    [ApiController]

    [Area("BdyTemperature")]
    [Route("api/BdyTemperature/[controller]")]

    public class BodyTemperatureAPIExController : ControllerBase
    {

        [HttpPost]
        public APIResponce PostAsync(BodyTemperatureAPIRequest req)
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

                //var dassgn = db.DeviceAssigns.Where(w => w.DeviceId == req.DeviceId).OrderBy(w => w.ConnectNo).LastOrDefault();
                if (devzassign != null)
                {
                    BodyTemperature bodytemp = new BodyTemperature()
                    {
                        ConnectId = devzassign.DeviceAssign.ConnectNo,
                        UserId = devzassign.DeviceAssign.UserId,
                        Temperature = req.Temperature,
                        DeviceTime = req.DiviceTime,
                        CheckedTimestamp = DateTime.UtcNow,
                    };
                    db.BodyTemperatures.Add(bodytemp);
                }
                db.SaveChanges();
                checktemprure(req);
            }
            APIResponce aPIResponce = new APIResponce();
            aPIResponce.IsChangeWaiting = true;
            aPIResponce.WaitingTime = 1000;
            return aPIResponce;
        }

        public int checktemprure(BodyTemperatureAPIRequest req)
        {
            Microsoft.AspNetCore.Http.HttpContext context = Request.HttpContext;

            using (SmartWatchContext db = new SmartWatchContext())
            {


                var devzassign = db.DeviceAssigns.Join(
                   db.Devices.Where(w => w.DeviceCode == req.DeviceCode),
                  deviceassg => deviceassg.DeviceId,
                  dvice => dvice.DeviceId,
                  (deviceassg, dvice) => new { DeviceAssign = deviceassg, Device = dvice }
                   );

                var uconfig = devzassign.Join(
                    db.UserConfigurations.Where(w => w.ConfigurationId == 1),
                    dvs => dvs.DeviceAssign.UserId,
                    uconf => uconf.UserId,
                    (dvs, uconf) => new { DeviceAssign = dvs, UserConfiguration = uconf }
                   );
                userconfigurationViewModel userconfigurationViewModel = new userconfigurationViewModel();
                foreach (var item in uconfig)
                {
                    userconfigurationViewModel.UserId = item.UserConfiguration.UserId;
                    userconfigurationViewModel.ConfigurationId = item.UserConfiguration.ConfigurationId;
                    userconfigurationViewModel.Value = item.UserConfiguration.Value;

                }
                decimal dt = Convert.ToDecimal(req.Temperature);
                if (dt > userconfigurationViewModel.Value)
                {
                    // hiiii
                }
                else
                {


                }

            }

            return 0;
        }

        public IEnumerable Get()
        {
            //Global.LogMessage("Data from Controller");
            return new string[] { "value1", "value2" };
        }
        public string Get(string id)
        {
            //Global.LogMessage("Request param : " + id);
            return "value";
        }



    }

    public class APIResponce
    {
        public int WaitingTime { get; set; } = 2000;
        public bool IsChangeWaiting { get; set; } = false;
        public int ResultCode { get; set; } = 0;

    }
}
