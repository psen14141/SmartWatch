using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartWatch.DbModels;
using Newtonsoft.Json;
using System.Web;

namespace SmartWatch.Areas.HeartRatee.Controllers
{
    [Area("HeartRatee")]
    public class HeartRateController : Controller
    {
        public IActionResult Index(int Userid )
        {


            List<HeartRate> heartRate = new List<HeartRate>();
            using (SmartWatchContext db = new SmartWatchContext())
            {
                heartRate = db.HeartRates.Where(w=>w.UserId == Userid).ToList();

            }
            ViewBag.Userid = Userid;
            return View(heartRate);
        }
        public ActionResult GetHeartRateDataByDateRange(DateTime fromdate, DateTime todate)
        {
            using (SmartWatchContext db = new SmartWatchContext())
            {
                //22/02/2021 12:00:00 AM
                String date = DateTime.Now.Date.ToString();
                Console.WriteLine("fromdate= "+ fromdate+ " todate= " + todate);

                List<HeartRate> productList = db.HeartRates.Where(w => w.DeviceTime.Date == fromdate || w.DeviceTime.Date == todate).ToList();
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
        public ActionResult GetHeartRateData() 
        {
            using (SmartWatchContext db = new SmartWatchContext())
            {
                //22/02/2021 12:00:00 AM
                String date = DateTime.Now.Date.ToString();
                DateTime dt1 = new DateTime(2021, 03, 02);
                DateTime dt2 = new DateTime(2021, 03, 02);
                List<HeartRate> productList = db.HeartRates.ToList();
                LineData timestamps = new LineData();
                HeartRates hr = new HeartRates();
                foreach (var item in productList) {

                    timestamps.labels.Add(item.DeviceTime.ToString());
                    hr.heartRate.Add((int)Math.Round(item.PulseRate));
                }
                timestamps.data= hr;
                return Content(JsonConvert.SerializeObject(timestamps), "application/json");
            }

        }
        public ActionResult GetHRData(int userId)
        {

            var date = DateTime.Now.ToShortDateString();
            using (DbModels.SmartWatchContext db = new DbModels.SmartWatchContext())
            {
                LineData timeStamps = new LineData();

                HeartRates hr = new HeartRates();

                for (int i = 1; i < 61; i++)
                {


                    var productList = db.HeartRates.Where(w => w.DeviceTime.Date == DateTime.Now.Date).Where(w => w.UserId == userId).Where(w => w.DeviceTime.Minute == i).FirstOrDefault();
                    DateTime now = DateTime.Now;


                    if (productList != null)
                    {
                        TimeSpan span = now.Subtract(productList.DeviceTime);
                        var min = span.TotalMinutes;
                        if (min <= 60)
                        {
                            hr.heartRate.Add((int)Math.Round(productList.PulseRate));
                        }

  
                    }else{

                         continue;
                    }

                    timeStamps.labels.Add(i.ToString());
                }

                timeStamps.data = hr;
                return Content(JsonConvert.SerializeObject(timeStamps), "application/json");
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

   
    }
}
