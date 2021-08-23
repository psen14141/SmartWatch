using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using SmartWatch.ProPlatform.Security;
using System.Linq;
using System.Threading.Tasks;
using SmartWatch.DbModels;
using SmartWatch.Areas.Dashboard.Models.ViewModels;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;

namespace SmartWatch.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            List<Profile> pvm = new List<Profile>();
            using (SmartWatchContext db = new SmartWatchContext())
            {
                pvm = db.Profiles.ToList();

            }

            return View(pvm);
        }

        public string getPatientName(int patientId) {
            string patientName = "name";

            using (SmartWatchContext db=new SmartWatchContext()) {

               var user = db.Users.Where(w => w.UserId == patientId).FirstOrDefault();
                patientName = user.Username;
            }

                return patientName;
        
        }
        public IActionResult PatientsDetailsView() {

            int LoggedStuffId= Convert.ToInt32(HttpContext.Session.GetString(SessionKeys.UserId));

            List<ProfileViewModel> profileViewModels = new List<ProfileViewModel>();
            ProfileViewModel profileViewModel1 = new ProfileViewModel();
            using (SmartWatchContext db = new SmartWatchContext())
            {
                   var user = db.Users.Where(w=>w.UserIsdelete == false).Join
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

                    var assign = db.PatientAssigns.Where(w => w.PatientId == profileViewModel.UserId && w.PatientAssignedIsDelete == false).FirstOrDefault();
                    if (assign != null)
                    {

                        if (assign.AssignedStaffId == LoggedStuffId)
                        {

                            try
                            {

                                var userBloodPressure = db.BloodPressures.OrderByDescending(stu => stu.BloodPressureUpper).Where(w => w.UserId == item.Role.UserId)
                                .OrderBy(o => o.BloodPressureId).LastOrDefault();
                                var userStepCount = db.StepCounts.Where(w => w.UserId == item.Role.UserId)
                                    .Where(w => w.DeviceTime.Date == DateTime.Now.Date).Sum(s => s.Steps);

                                var userHeartRate = db.HeartRates.Where(w => w.UserId == item.Role.UserId)
                                    .OrderBy(o => o.RecId).LastOrDefault();

                                var userBodyTemprature = db.BodyTemperatures.Where(w => w.BodyTemperatureIsDelete == false)
                                    .Where(w => w.UserId == item.Role.UserId)
                                    .OrderBy(o => o.BodyTemperatureId).LastOrDefault();

                                profileViewModel.Steps = userStepCount;
                                if (userBloodPressure != null)
                                {
                                    profileViewModel.bloodPressureUpper = userBloodPressure.BloodPressureUpper;
                                    profileViewModel.bloodPressureLower = userBloodPressure.BloodPreesureLower;
                                }
                                else
                                {

                                    profileViewModel.bloodPressureUpper = 0;
                                    profileViewModel.bloodPressureLower = 0;
                                }
                                if (userHeartRate != null)
                                {
                                    profileViewModel.PulseRate = userHeartRate.PulseRate;
                                }
                                else
                                {
                                    profileViewModel.PulseRate = 0;

                                }
                                if (userBodyTemprature != null)
                                {

                                    profileViewModel.Temperature = userBodyTemprature.Temperature;
                                }
                                else
                                {
                                    profileViewModel.Temperature = 0;

                                }

                            }
                            catch (NullReferenceException ex)
                            {
                                Console.WriteLine(ex);

                            }

                            profileViewModels.Add(profileViewModel);
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else { continue; }

                    //var max = db.BloodPressures.Max(i => i.BloodPressureUpper);


                }

                return Content(JsonConvert.SerializeObject(profileViewModels), "application/json");
            }
        }
        public IActionResult PatientsDetailsViewById(int userid)
        {

            List<ProfileViewModel> profileViewModels = new List<ProfileViewModel>();
            ProfileViewModel profileViewModel1 = new ProfileViewModel();
            using (SmartWatchContext db = new SmartWatchContext())
            {
                var user = db.Users.Where(W=>W.UserId == userid).Join
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

                        var userBloodPressure = db.BloodPressures.OrderByDescending(stu => stu.BloodPressureUpper).Where(w => w.UserId == item.Role.UserId)
                        .OrderBy(o => o.BloodPressureId).LastOrDefault();
                        var userStepCount = db.StepCounts.Where(w => w.UserId == item.Role.UserId)
                            .Where(w => w.DeviceTime.Date == DateTime.Now.Date).Sum(s => s.Steps);

                        var userHeartRate = db.HeartRates.Where(w => w.UserId == item.Role.UserId)
                            .OrderBy(o => o.RecId).LastOrDefault();

                        var userBodyTemprature = db.BodyTemperatures.Where(w => w.BodyTemperatureIsDelete == false)
                            .Where(w => w.UserId == item.Role.UserId)
                            .OrderBy(o => o.BodyTemperatureId).LastOrDefault();

                        profileViewModel.Steps = userStepCount;
                        if (userBloodPressure != null)
                        {
                            profileViewModel.bloodPressureUpper = userBloodPressure.BloodPressureUpper;
                            profileViewModel.bloodPressureLower = userBloodPressure.BloodPreesureLower;
                        }
                        else
                        {

                            profileViewModel.bloodPressureUpper = 0;
                            profileViewModel.bloodPressureLower = 0;
                        }
                        if (userHeartRate != null)
                        {
                            profileViewModel.PulseRate = userHeartRate.PulseRate;
                        }
                        else
                        {
                            profileViewModel.PulseRate = 0;

                        }
                        if (userBodyTemprature != null)
                        {

                            profileViewModel.Temperature = userBodyTemprature.Temperature;
                        }
                        else
                        {
                            profileViewModel.Temperature = 0;

                        }

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
        public IActionResult PatientsDetailsPage(int userid)
        {

            List<ProfileViewModel> profileViewModels = new List<ProfileViewModel>();
            ProfileViewModel profileViewModel = new ProfileViewModel();
            using (SmartWatchContext db = new SmartWatchContext())
            {

                try
                {

                    var userBloodPressure = db.BloodPressures.OrderByDescending(stu => stu.BloodPressureUpper).Where(w => w.UserId == userid )
                    .OrderBy(o => o.BloodPressureId).LastOrDefault();
                    var userStepCount = db.StepCounts.Where(w => w.UserId == userid)
                        .Where(w => w.DeviceTime.Date == DateTime.Now.Date).Sum(s => s.Steps);

                    var userHeartRate = db.HeartRates.Where(w => w.UserId == userid)
                        .OrderBy(o => o.RecId).LastOrDefault();

                    var userBodyTemprature = db.BodyTemperatures.Where(w => w.BodyTemperatureIsDelete == false)
                        .Where(w => w.UserId == userid)
                        .OrderBy(o => o.BodyTemperatureId).LastOrDefault();

                    profileViewModel.Steps = userStepCount;
                    if (userBloodPressure != null)
                    {
                        profileViewModel.bloodPressureUpper = userBloodPressure.BloodPressureUpper;
                        profileViewModel.bloodPressureLower = userBloodPressure.BloodPreesureLower;
                    }
                    else
                    {

                        profileViewModel.bloodPressureUpper = 0;
                        profileViewModel.bloodPressureLower = 0;
                    }
                    if (userHeartRate != null)
                    {
                        profileViewModel.PulseRate = userHeartRate.PulseRate;
                    }
                    else
                    {
                        profileViewModel.PulseRate = 0;

                    }
                    if (userBodyTemprature != null)
                    {

                        profileViewModel.Temperature = userBodyTemprature.Temperature;
                    }
                    else
                    {
                        profileViewModel.Temperature = 0;

                    }

                }
                catch (NullReferenceException ex)
                {
                    Console.WriteLine(ex);

                }







                    profileViewModels.Add(profileViewModel);
                    ViewBag.userid = userid;

                return View(profileViewModels);
            }
        }
        public IActionResult getAllPatientDataCount()
        {
            List<int> data_list = new List<int>();
            List<int> Bp_list = getBPPatientCount();
            List<int> Hr_list = getHeartRatePatientCount();
            List<int> Bt_list = getBTempPatientCount();
            List<int> Sc_list = getStepCountPatientCount();
            data_list.Add(Bp_list[0]);
            data_list.Add(Bp_list[1]);
            data_list.Add(Bp_list[2]);

            data_list.Add(Hr_list[0]);
            data_list.Add(Hr_list[1]);
            data_list.Add(Hr_list[2]);

            data_list.Add(Bt_list[0]);
            data_list.Add(Bt_list[1]);
            data_list.Add(Bt_list[2]);

            data_list.Add(Sc_list[0]);
            data_list.Add(Sc_list[1]);


            return Json(data_list);
        }

        public List<int> getHeartRatePatientCount()
        {

            int redCount = 0;
            int yellowCount = 0;
            int greenCount = 0;
            List<int> HR_list = new List<int>();
            int currentUserId = Convert.ToInt32(HttpContext.Session.GetString(SessionKeys.UserId));
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
                    DateTime today = DateTime.Today;
                    DateTime now = DateTime.Now;

                    var userHeartRate = db.HeartRates.Where(w => w.UserId == item.Role.UserId && DateTime.Compare(today, w.DeviceTime.Date) == 0)
                        .OrderBy(o => o.RecId).LastOrDefault();
                    if (userHeartRate == null)
                    {

                        continue;

                    }
                    var Hrate = userHeartRate.PulseRate;


                    TimeSpan span = now.Subtract(userHeartRate.DeviceTime);
                    var min = span.TotalMinutes;
                    if (min <= 60)
                    {


                        if ((Hrate <= 114) || (Hrate > 171))
                        {
                            redCount++;


                        }
                        else if ((Hrate > 114 && Hrate <= 133) || (Hrate > 152 && Hrate <= 171))
                        {
                            yellowCount++;

                        }
                        else if (Hrate > 133 && Hrate <= 152)
                        {
                            greenCount++;

                        }

                    }


                }

                HR_list.Add(redCount);
                HR_list.Add(yellowCount);
                HR_list.Add(greenCount);

                return HR_list;
            }

        }
        public List<int> getBTempPatientCount()
        {

            int redCount = 0;
            int yellowCount = 0;
            int greenCount = 0;
            List<int> BT_list = new List<int>();

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
                    DateTime today = DateTime.Today;
                    DateTime now = DateTime.Now;

                    var userBodyTemparature = db.BodyTemperatures.Where(w => w.UserId == item.Role.UserId && DateTime.Compare(today, w.DeviceTime.Date) == 0)
                        .OrderBy(o => o.BodyTemperatureId).LastOrDefault();
                    if (userBodyTemparature == null)
                    {

                        continue;

                    }
                    var Btemp = userBodyTemparature.Temperature;


                    TimeSpan span = now.Subtract(userBodyTemparature.DeviceTime);
                    var min = span.TotalMinutes;
                    if (min <= 60)
                    {
                        if (Btemp < 35 || Btemp >= 38)
                        {
                            redCount++;


                        } else if (Btemp < 36 || Btemp >= 37) {
                            yellowCount++;

                        }
                        else if (Btemp >= 36.1 && Btemp < 37)
                        {
                            greenCount++;

                        }

                    }


                }

                BT_list.Add(redCount);
                BT_list.Add(yellowCount);
                BT_list.Add(greenCount);

                return BT_list;
            }

        }
        public List<int> getStepCountPatientCount()
        {

            int yellowCount = 0;
            int greenCount = 0;
            List<int> SC_list = new List<int>();

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
                    DateTime today = DateTime.Today;
                    DateTime now = DateTime.Now;

                    var userStepCount = db.StepCounts.Where(w => w.UserId == item.Role.UserId && DateTime.Compare(today, w.DeviceTime.Date) == 0)
                        .OrderBy(o => o.StepCountId).LastOrDefault();
                    if (userStepCount == null)
                    {

                        continue;

                    }
                    var stepCount = userStepCount.Steps;


                    TimeSpan span = now.Subtract(userStepCount.DeviceTime);
                    var min = span.TotalMinutes;
                    if (min <= 60)
                    {
                        if (stepCount < 8000)
                        {
                            yellowCount++;


                        }
                        else if (stepCount >= 8000 || stepCount < 12000)
                        {
                            greenCount++;

                        }
                        else if (stepCount >= 12000)
                        {
                            yellowCount++;

                        }

                    }


                }


                SC_list.Add(yellowCount);
                SC_list.Add(greenCount);

                return SC_list;
            }

        }
        public List<int> getBPPatientCount() {

            int redCount = 0;
            int yellowCount = 0;
            int greenCount = 0;
            List<int> BP_list = new List<int>();

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
                    DateTime today = DateTime.Today;
                    DateTime now = DateTime.Now;

                    var userBloodPressure = db.BloodPressures.Where(w => w.UserId == item.Role.UserId && DateTime.Compare(today, w.DeviceTime.Date) == 0)
                        .OrderBy(o => o.BloodPressureId).LastOrDefault();

                    if (userBloodPressure == null)
                    {

                        continue;

                    }
                    var bpId = userBloodPressure.BloodPressureId;

                    var U_BP = userBloodPressure.BloodPressureUpper;
                    var L_BP = userBloodPressure.BloodPreesureLower;

                    TimeSpan span = now.Subtract(userBloodPressure.DeviceTime);
                    var min = span.TotalMinutes;
                    if (min <= 60)
                    {

                        string uBP_flag = checkUpperBP(U_BP);
                        string lBP_flag = checkLowerBP(L_BP);

                        if (uBP_flag == "FLAG_RED" || lBP_flag == "FLAG_RED") {
                            redCount++;
                        }else if (uBP_flag == "FLAG_YELLOW" || lBP_flag == "FLAG_YELLOW")
                        {
                            yellowCount++;
                        }else if (uBP_flag == "FLAG_GREEN" || lBP_flag == "FLAG_GREEN")
                        {
                            greenCount++;
                        }

                    }


                }

                BP_list.Add(redCount);
                BP_list.Add(yellowCount);
                BP_list.Add(greenCount);

                return BP_list;
            }

        }

        public string checkUpperBP(double UBP) {

            string flag = "NO_FLAG";
            //check upper blod pressure 
            if (UBP <= 100 || UBP >= 139)
            {
                flag = "FLAG_RED";


            }
            else if ((UBP > 100 && UBP <= 110) || (UBP > 120 && UBP <= 139))
            {
                flag = "FLAG_YELLOW";


            }
            else if ((UBP > 110 && UBP <= 120))
            {
                flag = "FLAG_GREEN";


            }
            return flag;
        }
        public string checkLowerBP(double LBP)
        {

            string flag = "NO_FLAG";
            //check upper blod pressure 
            if (LBP <= 70 || LBP >= 100)
            {
                flag = "FLAG_RED";


            }
            else if ((LBP > 70 && LBP <= 80) || (LBP > 90 && LBP <= 100))
            {
                flag = "FLAG_YELLOW";


            }
            else if ((LBP > 80 && LBP <= 90))
            {
                flag = "FLAG_GREEN";


            }
            return flag;
        }
    }
}
