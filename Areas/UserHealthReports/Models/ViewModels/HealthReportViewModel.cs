using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartWatch.DbModels;


namespace SmartWatch.Areas.UserHealthReport.Models.ViewModels
{
    public class HealthReportViewModel
    {

        public List<BloodPressure> BPressure = new List<BloodPressure>();
        public List<StepCount> SCount = new List<StepCount>();
        public List<BodyTemperature> BTemperature = new List<BodyTemperature>();
        public List<HeartRate> HRate = new List<HeartRate>();



    }
}
