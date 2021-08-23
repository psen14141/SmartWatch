using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SmartWatch.DbModels;
using SmartWatch.Areas.StepCountt.Models.ViewModels;
using SmartWatch.Areas.Dashboard.Models.ViewModels;
namespace SmartWatch.Areas.StepCountt.Controllers
{
    [Area("StepCountt")]
    public class StepCountController : Controller
    {

        public IActionResult Index(int userid)
        {
            List<StepCountViewModel> stepCountViewModels = new List<StepCountViewModel>();
            using (DbModels.SmartWatchContext db = new DbModels.SmartWatchContext())
            {
                ViewBag.userid = userid;
                string todayday = DateTime.Now.Day.ToString();
                string todaymonth = DateTime.Now.ToString("MMM");
                string todayyear = DateTime.Now.Year.ToString();
                string dateSuffix = GetOrdinalSuffix(DateTime.Now.Day);
                ViewBag.datewithsuffix = todayday + dateSuffix + " of " + todaymonth + ", " + todayyear;

                var stepCountUser = db.StepCounts.Join(db.Users.Where(w=> w.UserId == userid).Where(w=> w.UserIsdelete == false),
                    stepCount => stepCount.UserId,
                    users => users.UserId,
                    (stepCounts, users) => new {StepCounts = stepCounts, User = users}
                    ).FirstOrDefault();

                if (userid != 0)
                {
                    StepCountViewModel stepCountViewModel = new StepCountViewModel();
                    stepCountViewModel.UserId = userid;
                    //stepCountViewModel.Username = stepCountUser.User.Username;
                    //stepCountViewModel.Email = stepCountUser.User.Email;
                    //stepCountViewModel.ProfileId = stepCountUser.User.ProfileId;
                    stepCountViewModel.users = db.Users.Where(w => w.UserId == userid).ToList();

                    var weekly = GetWeeklyData(userid);
                    var monthly = GetMonthlyData(userid);

                    stepCountViewModel.WeeklyCount = weekly;
                    stepCountViewModel.MonthlyCount = monthly;
                    stepCountViewModels.Add(stepCountViewModel);

                    stepCountViewModels = stepCountViewModels.ToList();
                }
             
            }
            return View(stepCountViewModels);
        }
        public ActionResult GetStepCountData(DateTime givenDate, int userId)
        {
            using (DbModels.SmartWatchContext db = new DbModels.SmartWatchContext())
            {
                LineData timeStamps = new LineData();
                StepCounts steps = new StepCounts();

                timeStamps.labels.Add("0AM");
                timeStamps.labels.Add("1AM");
                timeStamps.labels.Add("2AM");
                timeStamps.labels.Add("3AM");
                timeStamps.labels.Add("4AM");
                timeStamps.labels.Add("5AM");
                timeStamps.labels.Add("6AM");
                timeStamps.labels.Add("7AM");
                timeStamps.labels.Add("8AM");
                timeStamps.labels.Add("9AM");
                timeStamps.labels.Add("10AM");
                timeStamps.labels.Add("11AM");
                timeStamps.labels.Add("12PM");
                timeStamps.labels.Add("1PM");
                timeStamps.labels.Add("2PM");
                timeStamps.labels.Add("3PM");
                timeStamps.labels.Add("4PM");
                timeStamps.labels.Add("5PM");
                timeStamps.labels.Add("6PM");
                timeStamps.labels.Add("7PM");
                timeStamps.labels.Add("8PM");
                timeStamps.labels.Add("9PM");
                timeStamps.labels.Add("10PM");
                timeStamps.labels.Add("11PM");
                timeStamps.labels.Add("12AM");

                for(int i = 0; i < 24; i++)
                {
                    if (givenDate.Date == DateTime.Now.Date)
                    {
                        var dailyStepCountSum = db.StepCounts.Where(w => w.Timestamp.Date == DateTime.Now.Date)
                            .Where(w => w.UserId == userId).Where(w => w.Timestamp.Hour == i).Sum(s => s.Steps);
                                steps.stepCount.Add((int)dailyStepCountSum);
                    }
                    else
                    {
                        var dailyStepCountSum = db.StepCounts.Where(w => w.Timestamp.Date == givenDate.Date)
                            .Where(w => w.UserId == userId).Where(w => w.Timestamp.Hour == i).Sum(s => s.Steps);
                        steps.stepCount.Add((int)dailyStepCountSum);
                    }
                }

            timeStamps.data = steps;
            return Content(JsonConvert.SerializeObject(timeStamps), "application/json");
            }
        }

        public ActionResult GetWeeklyStepCountData(int userId)
        {
            using (DbModels.SmartWatchContext db = new DbModels.SmartWatchContext())
            {
                string dt = DateTime.Now.DayOfWeek.ToString();
                LineData dataList = new LineData();
                LineData timeStamps = new LineData();
                StepCounts steps = new StepCounts();

                timeStamps.labels.Add("SUN");
                timeStamps.labels.Add("MON");
                timeStamps.labels.Add("TUE");
                timeStamps.labels.Add("WED");
                timeStamps.labels.Add("THU");
                timeStamps.labels.Add("FRI");
                timeStamps.labels.Add("SAT");

                List<DbModels.StepCount> generalList = db.StepCounts.Where(w=> w.UserId == userId).ToList();

                DateTime dateValue = DateTime.Now.Date.AddDays(1);
                DateTime[] weekDays = Enumerable.Range(0, (int)dateValue.DayOfWeek)
                    .Select(i => DateTime.Now.Date.AddDays(-i)).ToArray();

                var lastDays = weekDays.Reverse();

                foreach (var day in lastDays)
                {
                    var stepCountData = generalList.Where(w => w.DeviceTime.Date == day).Sum(s => s.Steps);
                    steps.stepCount.Add((int)stepCountData);
                }
                timeStamps.data = steps;
                return Content(JsonConvert.SerializeObject(timeStamps), "application/json");
            }
        }
        public ActionResult GetMounthlyStepCountData(int userId, int yearSelect)
        {
            using (DbModels.SmartWatchContext db = new DbModels.SmartWatchContext())
            {
                LineData timeStamps = new LineData();
                StepCounts steps = new StepCounts();

                timeStamps.labels.Add("JAN");
                timeStamps.labels.Add("FEB");
                timeStamps.labels.Add("MAR");
                timeStamps.labels.Add("APR");
                timeStamps.labels.Add("MAY");
                timeStamps.labels.Add("JUN");
                timeStamps.labels.Add("JUL");
                timeStamps.labels.Add("AUG");
                timeStamps.labels.Add("SEP");
                timeStamps.labels.Add("OCT");
                timeStamps.labels.Add("NOV");
                timeStamps.labels.Add("DEC");

                int thisMounth = DateTime.Now.Month;
                int thisYear = DateTime.Now.Year;
                List<DbModels.StepCount> generalList = db.StepCounts.Where(w=> w.UserId == userId).ToList();
                if (yearSelect == 0)
                {
                    for (int i = 1; i <= thisMounth; i++)
                    {
                        var mounthlyStepCount = generalList.Where(w => w.DeviceTime.Year == DateTime.Now.Year)
                            .Where(w => w.DeviceTime.Month == i).Where(w => w.UserId == userId).Sum(s => s.Steps);

                        steps.stepCount.Add((int)mounthlyStepCount);
                    }
                    timeStamps.data = steps;
                    return Content(JsonConvert.SerializeObject(timeStamps), "application/json");
                }
                else
                {
                    for (int i = 1; i <= thisMounth; i++)
                    {
                        var mounthlyStepCount = generalList.Where(w => w.DeviceTime.Year == yearSelect)
                            .Where(w => w.DeviceTime.Month == i).Where(w => w.UserId == userId).Sum(s => s.Steps);

                        steps.stepCount.Add((int)mounthlyStepCount);
                    }
                    timeStamps.data = steps;
                    return Content(JsonConvert.SerializeObject(timeStamps), "application/json");
                }
            }
        }

        public ActionResult GetWeeklyDateRange(int userId, string fromdate, string todate)
        {
            using (DbModels.SmartWatchContext db = new DbModels.SmartWatchContext())
            {
                LineData timeStamps = new LineData();
                StepCounts steps = new StepCounts();
                DateTime fromDate = Convert.ToDateTime(fromdate);
                DateTime toDate = Convert.ToDateTime(todate);

                List<DbModels.StepCount> generalList = db.StepCounts.Where(w => w.UserId == userId).ToList();

                TimeSpan t = toDate - fromDate;
                int elapsedDays = t.Days + 1;
                DateTime[] weekDays = Enumerable.Range(0, elapsedDays)
                    .Select(i => fromDate.Date.AddDays(i)).ToArray();

                foreach (var day in weekDays)
                {
                    string dayofWeek = day.ToString("ddd").ToUpper();
                    string suffix = GetOrdinalSuffix(day.Day);
                    string month = day.ToString("MMM").ToUpper();
                    string graphLabels = dayofWeek + ", " + day.Day + suffix + " of " + month;
                    timeStamps.labels.Add(graphLabels);
                    var stepCountData = generalList.Where(w => w.Timestamp.Date == day.Date).Sum(s => s.Steps);
                    steps.stepCount.Add((int)stepCountData);

                }

                timeStamps.data = steps;
                return Content(JsonConvert.SerializeObject(timeStamps), "application/json");
            }
        }
        private static string GetOrdinalSuffix(int num)
        {
            string number = num.ToString();
            if (number.EndsWith("11")) return "th";
            if (number.EndsWith("12")) return "th";
            if (number.EndsWith("13")) return "th";
            if (number.EndsWith("1")) return "st";
            if (number.EndsWith("2")) return "nd";
            if (number.EndsWith("3")) return "rd";
            return "th";
        }

        public class LineData
        {
            public List<string> labels { get; set; } = new List<string>();
            public StepCounts data { get; set; } = new StepCounts();
            public int dayNumber { get; set; } = new int();

        }
        public class StepCounts
        {
            public List<int> stepCount { get; set; } = new List<int>();
        }

        public List<StepCountViewModel> GetWeeklyData(int userId)
        {
            using (DbModels.SmartWatchContext db = new DbModels.SmartWatchContext())
            {
                List<StepCountViewModel> weeklyDatas = new List<StepCountViewModel>();

                DateTime dateValue = DateTime.Now.Date;
                DateTime[] weekDays = Enumerable.Range(0, (int)dateValue.DayOfWeek)
                  .Select(i => DateTime.Now.Date.AddDays(-i - 1)).ToArray();

                List<DbModels.StepCount> generalList = db.StepCounts.Where(w => w.UserId == userId).ToList();

                foreach(var day in weekDays)
                {
                    var totalsteps = generalList.Where(w => w.UserId == userId)
                        .Where(w => w.DeviceTime.Date == day).Sum(s => s.Steps);
                    var dateName = day.ToString("ddd");
                    string suffix = GetOrdinalSuffix(day.Day);
                    string dateNo = day.ToString("dd") + suffix;
                    string thisDate = day.ToString("yyyy/MM/dd");
                    weeklyDatas.Add(new StepCountViewModel { weeklyStepCount = totalsteps, weeklyStepName = dateName, datewithSuffix = dateNo, weekDates = thisDate });
                }

                return weeklyDatas;

            }

        }

        public List<StepCountViewModel> GetMonthlyData (int userId)
        {
            using (DbModels.SmartWatchContext db = new DbModels.SmartWatchContext())
            {
                List<StepCountViewModel> monthlyData = new List<StepCountViewModel>();
                int thisMounth = DateTime.Now.Month;

                List<DbModels.StepCount> generalList = db.StepCounts.Where(w => w.UserId == userId).ToList();

                for (int i = 1; i <= thisMounth; i++)
                {
                    var totalsteps = generalList.Where(w => w.DeviceTime.Year == DateTime.Now.Year)
                        .Where(w => w.DeviceTime.Month == i).Where(w => w.UserId == userId).Sum(s => s.Steps);
                    var dateName = DateTime.Now.AddMonths(-thisMounth+i).ToString("MMM");
                    monthlyData.Add(new StepCountViewModel { monthlyStepName = dateName, monthlyStepCount = totalsteps });
                }
                return monthlyData;
            }
        }

        public IActionResult PatientsDetailsViewById(int userid)
        {

            List<ProfileViewModel> profileViewModels = new List<ProfileViewModel>();
            ProfileViewModel profileViewModel1 = new ProfileViewModel();
            using (SmartWatchContext db = new SmartWatchContext())
            {
                var user = db.Users.Where(W => W.UserId == userid).Join
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
                    profileViewModel.UserSecret = item.Role.UserSecret;
                    profileViewModel.UserDynamickey = item.Role.UserSecret;
                    profileViewModel.RoleId = item.Role.RoleId;
                    profileViewModel.RoleName = item.Role.Role.RoleName;
                    profileViewModel.ProfileId = item.Role.ProfileId;
                    profileViewModel.CreateTime = item.Role.CreateTime;
                    profileViewModel.Password = item.Role.Password;
                    profileViewModel.Email = item.Role.Email;
                    profileViewModel.Mobile = item.Role.Mobile;
                    profileViewModel.UserIsdelete = item.Role.UserIsdelete;

                    //var max = db.BloodPressures.Max(i => i.BloodPressureUpper);
                    try
                    {



                        var userStepCount = db.StepCounts.Where(w => w.UserId == item.Role.UserId)
                            .Where(w => w.DeviceTime.Date == DateTime.Now.Date).Sum(s => s.Steps);


                        profileViewModel.Steps = userStepCount;
                    }
                    catch (NullReferenceException ex)
                    {
                        Console.WriteLine(ex);

                    }
                    profileViewModels.Add(profileViewModel);

                }
                return Content(JsonConvert.SerializeObject(profileViewModels), "application/json");
            }
        }

    }
}


