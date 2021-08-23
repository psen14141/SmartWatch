using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartWatch.DbModels;
using SmartWatch.Areas.BdyTemperature.Models.ViewModel;
using Newtonsoft.Json;

namespace SmartWatch.Areas.BdyTemperature.Conrollers
{
    [Area("BdyTemperature")]
    public class BodyTemperatureController : Controller
    {
        public IActionResult Index(int userid)
        {
            BodyTemperatureViewModel bodyTemperatureViewModel = new BodyTemperatureViewModel();
            List<BodyTemperatureViewModel> bodyTemperatureViewModels = new List<BodyTemperatureViewModel>();

            using (SmartWatchContext db = new SmartWatchContext())
            {
                if(userid != 0)
                {
                    ViewBag.UserId = userid;

                    //bodyTemperatureViewModel.bodyTemperatures = db.BodyTemperatures.Where(w => w.UserId == userid).ToList();

                    foreach (var item in bodyTemperatureViewModel.bodyTemperatures)
                    {
                        BodyTemperatureViewModel bodyTemperature = new BodyTemperatureViewModel();
                        bodyTemperature.userid = item.UserId;
                        bodyTemperature.BodyTemperatureId = item.BodyTemperatureId;
                        bodyTemperature.ConnectId = item.ConnectId;
                        bodyTemperature.DeviceTime = item.DeviceTime;
                        bodyTemperature.BodyTemperatureIsDelete = item.BodyTemperatureIsDelete;
                        bodyTemperature.users = db.Users.Where(w => w.UserId == userid).ToList();
                        bodyTemperatureViewModels.Add(bodyTemperature);
                    }

                }
            }

            return View(bodyTemperatureViewModels);
            
        }

        public ActionResult GetBodyTemperatureData(int UserId, string fromdate)
        {
            using (SmartWatchContext db = new SmartWatchContext())
            {
                BodyTemperatureViewModel bodyTemperatureViewModel = new BodyTemperatureViewModel();
                bodyTemperatureViewModel.bodyTemperatures = db.BodyTemperatures.Where(w => w.UserId == UserId).ToList();

                LineData timestamps = new LineData();
                BodyTemperatures hr = new BodyTemperatures();
                DateTime dt = new DateTime();
                DateTime fromDate = Convert.ToDateTime(fromdate);

                if (fromDate.Date.ToString() == dt.Date.ToString())
                {
                    foreach (var item in bodyTemperatureViewModel.bodyTemperatures)
                    {
                        int today = DateTime.Compare(DateTime.Today.Date, item.CheckedTimestamp.Date);

                        if (today == 0)
                        {
                            timestamps.labels.Add(item.DeviceTime.ToString());
                            hr.bodyTemperature.Add(item.Temperature);
                        }
                    }
                }
                timestamps.data = hr;
                return Content(JsonConvert.SerializeObject(timestamps), "application/json");
            }

        }


        public ActionResult TemperatureDateFilter(int UserId, string fromdate, string todate)
        {
            using (SmartWatchContext db = new SmartWatchContext())
            {
                BodyTemperatureViewModel bodyTemperature = new BodyTemperatureViewModel();
                bodyTemperature.bodyTemperatures = db.BodyTemperatures.Where(w => w.UserId == UserId).ToList();
                LineData timestamps = new LineData();
                BodyTemperatures hr = new BodyTemperatures();
                DateTime fromDate = Convert.ToDateTime(fromdate);
                DateTime toDate = Convert.ToDateTime(todate);

                foreach (var item in bodyTemperature.bodyTemperatures)
                {
                    int intFrom = DateTime.Compare(fromDate.Date, item.CheckedTimestamp.Date);
                    int intTo = DateTime.Compare(toDate.Date, item.CheckedTimestamp.Date);

                    if ((intFrom <= 0) && (intTo >= 0))
                    {
                        timestamps.labels.Add(item.DeviceTime.ToString());
                        hr.bodyTemperature.Add(item.Temperature);
                    }
                }
                timestamps.data = hr;
                return Content(JsonConvert.SerializeObject(timestamps), "application/json");

            }

        }

        public class LineData
        {
            public List<string> labels { get; set; } = new List<string>();

            public BodyTemperatures data { get; set; } = new BodyTemperatures();
        }

        public class BodyTemperatures
        {
            public List<double> bodyTemperature { get; set; } = new List<double>();
        }

    }
}
