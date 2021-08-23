using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartWatch.ProPlatform.Notifications;
using System.Text.Json;
using SmartWatch.Areas.BloodPressur.Models.ViewModels;
using SmartWatch.DbModels;


namespace SmartWatch.Areas.BloodPressur.Controllers
{
    public class BllodPressureAlertSend
    {

        public int SendingbPressureAlert()
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

                    var userBloodpress = db.BloodPressures.Where(w => w.UserId == item.Role.UserId)
                        .OrderBy(o => o.BloodPressureId).LastOrDefault();

                    var Hrateupper = userBloodpress.BloodPressureUpper;
                    var Hratelower = userBloodpress.BloodPreesureLower;
                    var sendNoice = userBloodpress.SendNoise;


                    TimeSpan span = now.Subtract(userBloodpress.Checkedtime);
                    var min = span.TotalMinutes;
                    if (min <= 360 && sendNoice != true)
                    {


                        if ((Hratelower <= 114) || (Hrateupper > 171))
                        {

                            userBloodpress.SendNoise = true;
                            userBloodpress.SendValue = true;

                            AlertNote alert = new AlertNote();
                            alert.IsAlarm = true;
                            alert.PatientId = profileViewModel.UserId;
                            alert.PatientName = profileViewModel.Username;

                            string jsonString = JsonSerializer.Serialize(alert);

                            try
                            {
                                PushNotification.MakePushNotication(profileViewModel.Webapplicationtoken, "BloodPressure-Alert", jsonString);
                                PushNotification.MakePushNotication(profileViewModel.Mobiledevicetoken, "BloodPressure-Alert", jsonString);
                            }
                            catch (Exception)
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
}
