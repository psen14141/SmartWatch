using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartWatch.DbModels;
using Newtonsoft.Json;

namespace SmartWatch.Areas.UserHealthReport.Controllers
{

    [Area("UserHealthReports")]
    public class UserHealthReportController : Controller
    {
        public IActionResult Index()
        {

            List<HeartRate> heartRate = new List<HeartRate>();
            using (SmartWatchContext db = new SmartWatchContext())
            {
                heartRate = db.HeartRates.ToList();

            }

            return View(heartRate);
        }
        public ActionResult GetHeartRateData()
        {
            using (SmartWatchContext db = new SmartWatchContext())
            {
                int ID = 1;

                List<HeartRate> productList = db.HeartRates.Where(w => w.UserId == ID).ToList();
                LineData timestamps = new LineData();
                HeartRates hr = new HeartRates();
                foreach (var item in productList)
                {

                    timestamps.labels.Add(item.DeviceTime.ToString());
                    hr.heartRate.Add((int)Math.Round(item.PulseRate));
                }
                timestamps.data = hr;
                return Content(JsonConvert.SerializeObject(timestamps), "application/json");
            }
        }

        public class LineData
        {
            public List<string> labels { get; set; } = new List<string>();
            public HeartRates data { get; set; } = new HeartRates();
        }

        public class HeartRates
        {
            public List<int> heartRate { get; set; } = new List<int>();
        }

        public ActionResult GetBTemperatureData()
        {
            using (SmartWatchContext db = new SmartWatchContext())
            {
                int ID = 1;
                List<BodyTemperature> productList = db.BodyTemperatures.Where(w => w.UserId == ID).ToList();
                LineDataBP timestamps = new LineDataBP();
                BodyTem bt = new BodyTem();
                foreach (var item in productList)
                {

                    timestamps.labels.Add(item.DeviceTime.ToString());
                    bt.BTemperature.Add((int)Math.Round(item.Temperature));
                }
                timestamps.data = bt;
                return Content(JsonConvert.SerializeObject(timestamps), "application/json");
            }
        }


        public class LineDataBP
        {
            public List<string> labels { get; set; } = new List<string>();

            public BodyTem data { get; set; } = new BodyTem();
        }

        public class BodyTem
        {
            public List<int> BTemperature { get; set; } = new List<int>();
        }

        public ActionResult GetStepCountData()
        {
            using (SmartWatchContext db = new SmartWatchContext())
            {
                int ID = 1;
                List<StepCount> productList = db.StepCounts.Where(w => w.UserId == ID).ToList();
                LineDataStpCount timestamps = new LineDataStpCount();
                SCounts st = new SCounts();
                foreach (var item in productList)
                {

                    timestamps.labels.Add(item.DeviceTime.ToString());
                    st.stepCount.Add((int)item.Steps);
                }
                timestamps.data = st;
                return Content(JsonConvert.SerializeObject(timestamps), "application/json");
            }
        }

        public class LineDataStpCount
        {
            public List<string> labels { get; set; } = new List<string>();

            public SCounts data { get; set; } = new SCounts();
        }

        public class SCounts
        {
            public List<int> stepCount { get; set; } = new List<int>();
        }

        //Blood Pressure
        public ActionResult GetBloodPressureData()
        {
            using (SmartWatchContext db = new SmartWatchContext())
            {
                int ID = 1;
                List<BloodPressure> productList = db.BloodPressures.Where(w => w.UserId == ID).ToList();
                LineDataBloodPressure timestamps = new LineDataBloodPressure();
                BldPressure bp = new BldPressure();
                foreach (var item in productList)
                {
                    timestamps.labels.Add(item.DeviceTime.ToString());
                    bp.BPressure.Add((int)item.BloodPressureUpper);
                    bp.BPL.Add((int)Math.Round(item.BloodPreesureLower));
                }
                timestamps.data = bp;
                return Content(JsonConvert.SerializeObject(timestamps), "application/json");



            }
        }
        public class LineDataBloodPressure
        {
            public List<string> labels { get; set; } = new List<string>();

            public BldPressure data { get; set; } = new BldPressure();
        }

        public class BldPressure
        {
            public List<int> BPressure { get; set; } = new List<int>();

            public List<int> BPL { get; set; } = new List<int>();
        }
    }
}