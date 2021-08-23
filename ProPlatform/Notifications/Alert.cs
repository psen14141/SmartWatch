using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartWatch.ProPlatform.Notifications
{
    public class AlertNote
    {
       public bool IsAlarm { get; set; } = false; // True -> Client Make Noise
       public double BloodPresures { get; set; } = 0;
       public double Temperature { get; set; } = 0;
       public double HartRate { get; set; } = 0;
       public string PatientName { get; set; } = "";
       public int PatientId { get; set; } = 0;
       public bool RemoveAlarm { get; set; } = false;
    }
}
