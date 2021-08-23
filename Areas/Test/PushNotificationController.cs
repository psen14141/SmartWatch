using Microsoft.AspNetCore.Mvc;
using SmartWatch.DbModels;
using SmartWatch.ProPlatform.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace SmartWatch.Areas.test
{
    [Area("Test")]
    public class PushNotificationController : Controller
    {
        public string Index()
        {
            using (SmartWatchContext db = new SmartWatchContext())
            {
                User user = db.Users.Where(w => w.UserId == 1).First();
                AlertNote alert = new AlertNote();
                alert.IsAlarm = true;
                alert.BloodPresures = 79.2;
                alert.Temperature = 101.2;
                alert.HartRate = 71;
                alert.PatientName = "Pamoda";
                alert.PatientId = 2;
                alert.RemoveAlarm = false;

                string jsonString = JsonSerializer.Serialize(alert);

                PushNotification.MakePushNotication(user.Webapplicationtoken, "Test Title", jsonString);
            }
                
            return "test";
        }
    }
}
