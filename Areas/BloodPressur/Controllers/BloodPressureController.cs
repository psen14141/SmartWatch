 using Microsoft.AspNetCore.Mvc;
using SmartWatch.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using SmartWatch.Areas.BloodPressur.Models.ViewModels;
using System.Threading.Tasks;
//using SmartWatch.Areas.Dashboard.Models.ViewModels;


namespace SmartWatch.Areas.BloodPressur.Controllers
{

    [Area("BloodPressur")]
    public class BloodPressureController : Controller
    {
        public IActionResult Index(int userid)
        {
            ViewBag.userId = userid;

            List<BloodPressure> BPU = new List<BloodPressure>();
            using (SmartWatchContext db = new SmartWatchContext())
            {
                BPU = db.BloodPressures.Where(w=> w.UserId == userid).ToList();
                ViewBag.id = userid;
            }

            return View(BPU);
        }
        public ActionResult GetBloodPressureData(int id)
        {
            using (SmartWatchContext db = new SmartWatchContext())
            {
                List<BloodPressure> productList = db.BloodPressures.Where(w=> w.UserId==id).ToList();
                LineData timestamps = new LineData();
                BloodPressures bp = new BloodPressures();
                foreach (var item in productList)
                {

                    timestamps.labels.Add(item.DeviceTime.ToString());
                    bp.BPU.Add((int)Math.Round(item.BloodPressureUpper));
                    bp.BPL.Add((int)Math.Round(item.BloodPreesureLower));
                }
                timestamps.data = bp;
                return Content(JsonConvert.SerializeObject(timestamps), "application/json");
            }

        }




        public ActionResult BloodPresureDateFilter(int UserId, string fromdate, string todate)
        {
            using (SmartWatchContext db = new SmartWatchContext())
            {
                BloodPressureViewModel bloodPressure = new BloodPressureViewModel();
                bloodPressure.bloodPressures = db.BloodPressures.Where(w => w.UserId == UserId).ToList();
                LineData timestamps = new LineData();
                BloodPressures bp = new BloodPressures();
                DateTime fromDate = Convert.ToDateTime(fromdate);
                DateTime toDate = Convert.ToDateTime(todate);

                foreach (var item in bloodPressure.bloodPressures)
                {
                    int intFrom = DateTime.Compare(fromDate.Date, item.Checkedtime.Date);
                    int intTo = DateTime.Compare(toDate.Date, item.Checkedtime.Date);

                    if ((intFrom <= 0) && (intTo >= 0))
                    {
                        timestamps.labels.Add(item.DeviceTime.ToString());
                        bp.BPU.Add((int)Math.Round(item.BloodPressureUpper));
                        bp.BPL.Add((int)Math.Round(item.BloodPreesureLower));
                    }
                }
                timestamps.data = bp;
                return Content(JsonConvert.SerializeObject(timestamps), "application/json");

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
                    var userBloodPressure = db.BloodPressures.OrderByDescending(stu => stu.BloodPressureUpper).Where(w => w.UserId == item.Role.UserId)
                        .OrderBy(o => o.BloodPressureId).LastOrDefault();

                    profileViewModel.bloodPressureUpper = userBloodPressure.BloodPressureUpper;
                    profileViewModel.bloodPressureLower = userBloodPressure.BloodPreesureLower;
                    profileViewModel.checkedTime = userBloodPressure.Checkedtime;


                    profileViewModels.Add(profileViewModel);

                }

                return Content(JsonConvert.SerializeObject(profileViewModels), "application/json");
            }
        }




        public class LineData
        {
            public List<string> labels { get; set; } = new List<string>();

            public BloodPressures data { get; set; } = new BloodPressures();
        }

        public class BloodPressures
        {
            public List<int> BPU { get; set; } = new List<int>();
            public List<int> BPL { get; set; } = new List<int>();
        }



       

    }
}
