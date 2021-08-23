using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SmartWatch.Areas.HeartRatee.Models;
using SmartWatch.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartWatch.ProPlatform.Notifications;
using System.Text.Json;

namespace SmartWatch.Areas.HeartRatee.Controllers
{
    [Area("HeartRatee")]
    [Route("api/HeartRatee/[controller]")]
    [ApiController]
    public class HeartRateAPIExController : ControllerBase
    {
        [HttpPost]
        public APIResponce PostAsync(HeartRateAPIRequest req)
        {

            
            Microsoft.AspNetCore.Http.HttpContext context = Request.HttpContext;

            using (SmartWatchContext db = new SmartWatchContext())
            {
                var dassgn = db.DeviceAssigns.Join(
                    db.Devices.Where(w => w.DeviceCode == req.DeviceCode),
                    deviass => deviass.DeviceId,
                    device => device.DeviceId,
                    (deviass, device) => new {DeviceAssign = deviass, Devices = device}
                    ).OrderBy(w => w.DeviceAssign.ConnectNo).LastOrDefault();
                
                if (dassgn != null)
                {
                    HeartRate heartRate = new HeartRate()
                    {
                        ConnectionId = dassgn.DeviceAssign.ConnectNo,
                        UserId = dassgn.DeviceAssign.UserId,
                        PulseRate = req.HeartRate,
                        DeviceTime = req.DiviceTime,
                        CheckedTime = DateTime.UtcNow,
                    };
                    db.HeartRates.Add(heartRate);
                }
                db.SaveChanges();
               
            }
            APIResponce aPIResponce = new APIResponce();
            aPIResponce.IsChangeWaiting = true;
            aPIResponce.WaitingTime = 1000;
            return aPIResponce;
         
        }


        public int SendingAlert()
        {
            bool SendNoise = false;
            bool SendValue = false;
            bool StopAlarm = false;


            List<ProfileViewModel> profileViewModels = new List<ProfileViewModel>();
            ProfileViewModel profileViewModel1 = new ProfileViewModel();
            using (SmartWatchContext db = new SmartWatchContext())
            {
                var user = db.Users.Join
                   (db.Roles.Where(w => w.RoleName == "Patient"),
                   roletype => roletype.RoleId,
                   userget => userget.RoleId,
                   (roletype, userget) => new { Role = roletype, User = userget }
                   );

                foreach (var item in user)
                {
                    ProfileViewModel profileViewModel = new ProfileViewModel();
                    profileViewModel.UserId = item.Role.UserId;
                    profileViewModel.Username = item.Role.Username;
                    profileViewModel.Webapplicationtoken = item.Role.Webapplicationtoken;
                    profileViewModel.Mobiledevicetoken = item.Role.Mobiledevicetoken;
                    DateTime today = DateTime.Today;
                    DateTime now = DateTime.Now;

                    var userHeartRate = db.HeartRates.Where(w => w.UserId == item.Role.UserId )
                        .OrderBy(o => o.RecId).LastOrDefault();

                    var Hrate = userHeartRate.PulseRate;
                    var sendNoice = userHeartRate.SendNoise;


                    TimeSpan span = now.Subtract(userHeartRate.CheckedTime);
                    var min = span.TotalMinutes;
                    if (min <= 360 && sendNoice != true)
                    {


                        if ((Hrate <= 100) || (Hrate > 140) )
                        {
                           
                            userHeartRate.SendNoise = true;
                            userHeartRate.SendValue = true;

                            AlertNote alert = new AlertNote();
                            alert.IsAlarm = true;
                            alert.PatientId = profileViewModel.UserId;
                            alert.PatientName = profileViewModel.Username;

                            string jsonString = JsonSerializer.Serialize(alert);

                            try{
                                PushNotification.MakePushNotication(profileViewModel.Webapplicationtoken, "Hart-Rate-Alert", jsonString);
                                PushNotification.MakePushNotication(profileViewModel.Mobiledevicetoken, "Hart-Rate-Alert", jsonString);
                            }
                            catch(Exception)
                            {

                            }
                           

                        }
                    }


                }
                db.SaveChanges();

            }
            return 0;
        }
    }

   
    public class APIResponce
    {
        public int WaitingTime { get; set; } = 2000;
        public bool IsChangeWaiting { get; set; } = false;
        public int ResultCode { get; set; } = 0;
    }



}
