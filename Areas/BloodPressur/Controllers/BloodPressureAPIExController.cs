using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SmartWatch.Areas.BloodPressur.Models;
using SmartWatch.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartWatch.ProPlatform.Notifications;
using System.Text.Json;
using SmartWatch.Areas.BloodPressur.Models.ViewModels;

namespace SmartWatch.Areas.BloodPressur.Controllers
{
    [Area("BloodPressur")]
    [Route("api/BloodPressur/[controller]")]
    [ApiController]
    public class BloodPressureAPIExController : ControllerBase
    {

        [HttpPost]
        public APIResponce PostAsync(BloodPresureAPIRequest req)
        {

            Microsoft.AspNetCore.Http.HttpContext context = Request.HttpContext;
            double waitingTime = 1000;
            bool isChangeWaiting = false;

            using (SmartWatchContext db = new SmartWatchContext())
            {
                var devzassign = db.DeviceAssigns.Join(
                   db.Devices.Where(w => w.DeviceCode == req.DeviceCode),
                   deviceassg => deviceassg.DeviceId,
                   dvice => dvice.DeviceId,
                   (deviceassg, dvice) => new { DeviceAssign = deviceassg, Device = dvice }
                   ).OrderBy(w => w.DeviceAssign.ConnectNo).LastOrDefault();

                var dassgn = db.UserSequences.Where(w => w.UserId == devzassign.DeviceAssign.UserId).OrderBy(w => w.UserId).LastOrDefault();
                if (dassgn != null)
                {
                    DbModels.UserSequence userSequence = db.UserSequences.Where(w => w.UserId == devzassign.DeviceAssign.UserId).First();
                    if(userSequence != null)
                    {
                        if(userSequence.IsSentBloodPressure == true)
                        {
                            waitingTime = userSequence.ValuesInSeconds;
                            isChangeWaiting = true;
                        }
                    }
                }
          
            
               
                if (devzassign != null)
                {
                    BloodPressure bloodPressure = new BloodPressure()
                    {
                        ConnectionId = devzassign.DeviceAssign.ConnectNo,
                        UserId = devzassign.DeviceAssign.UserId,
                        BloodPressureUpper = req.BloodPresureUpper,
                        BloodPreesureLower = req.BloodPresureLower,
                        DeviceTime = req.DiviceTime,
                        Checkedtime = DateTime.UtcNow,
                        
                    };
                    db.BloodPressures.Add(bloodPressure);
                    
                }
                db.SaveChanges();


            }
            

            APIResponce aPIResponce = new APIResponce();
            //aPIResponce.IsChangeWaiting = true;
            //aPIResponce.WaitingTime = 1000;
            aPIResponce.IsChangeWaiting = isChangeWaiting;
            aPIResponce.WaitingTime = Convert.ToInt32(waitingTime);
            return aPIResponce;
        }


        //public int SendingAlert()
        //{
        //    bool SendNoise = false;
        //    bool SendValue = false;
        //    bool StopAlarm = false;


        //    List<ProfileViewModel> profileViewModels = new List<ProfileViewModel>();
        //    ProfileViewModel profileViewModel1 = new ProfileViewModel();
        //    using (SmartWatchContext db = new SmartWatchContext())
        //    {
        //        var user = db.Users.Join
        //           (db.Roles.Where(w => w.RoleName == "Patient"),
        //           roletype => roletype.RoleId,
        //           userget => userget.RoleId,
        //           (roletype, userget) => new { Role = roletype, User = userget }
        //           );

        //        foreach (var item in user)
        //        {
        //            ProfileViewModel profileViewModel = new ProfileViewModel();
        //            profileViewModel.UserId = item.Role.UserId;
        //            profileViewModel.Username = item.Role.Username;
        //            profileViewModel.Webapplicationtoken = item.Role.Webapplicationtoken;
        //            profileViewModel.Mobiledevicetoken = item.Role.Mobiledevicetoken;
        //            DateTime today = DateTime.Today;
        //            DateTime now = DateTime.Now;

        //            var userBloodpress = db.BloodPressures.Where(w => w.UserId == item.Role.UserId)
        //                .OrderBy(o => o.BloodPressureId).LastOrDefault();

        //            var Hrateupper = userBloodpress.BloodPressureUpper;
        //            var Hratelower = userBloodpress.BloodPreesureLower;
        //            var sendNoice = userBloodpress.SendNoise;


        //            TimeSpan span = now.Subtract(userBloodpress.Checkedtime);
        //            var min = span.TotalMinutes;
        //            if (min <= 360 && sendNoice != true)
        //            {


        //                if ((Hratelower <= 114) || (Hrateupper > 171))
        //                {

        //                    userBloodpress.SendNoise = true;
        //                    userBloodpress.SendValue = true;

        //                    AlertNote alert = new AlertNote();
        //                    alert.IsAlarm = true;
        //                    alert.PatientId = profileViewModel.UserId;
        //                    alert.PatientName = profileViewModel.Username;

        //                    string jsonString = JsonSerializer.Serialize(alert);

        //                    try
        //                    {
        //                        PushNotification.MakePushNotication(profileViewModel.Webapplicationtoken, "BloodPressure-Alert", jsonString);
        //                        PushNotification.MakePushNotication(profileViewModel.Mobiledevicetoken, "BloodPressure-Alert", jsonString);
        //                    }
        //                    catch (Exception)
        //                    {

        //                    }


        //                }
        //            }


        //        }
        //        db.SaveChanges();

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
