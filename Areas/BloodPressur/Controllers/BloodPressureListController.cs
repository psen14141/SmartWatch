using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SmartWatch.Areas.Dashboard.Models.ViewModels;
using SmartWatch.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartWatch.Areas.BloodPressur.Controllers
{

    [Area("BloodPressur")]
    public class BloodPressureListController : Controller
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
        public IActionResult PatientsDetailsView()
        {

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

                    var userBloodPressure = db.BloodPressures.OrderByDescending(stu => stu.BloodPressureUpper).Where(w => w.UserId == item.Role.UserId)
                       .OrderBy(o => o.BloodPressureId).LastOrDefault();

                    if (userBloodPressure != null)
                    {
                        profileViewModel.bloodPressureUpper = userBloodPressure.BloodPressureUpper;
                        profileViewModel.bloodPressureLower = userBloodPressure.BloodPreesureLower;
                        profileViewModels.Add(profileViewModel);
                    }

                }

                return Content(JsonConvert.SerializeObject(profileViewModels), "application/json");
            }
        }
    }
}