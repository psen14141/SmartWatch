using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartWatch.DbModels;
using SmartWatch.Areas.Dashboard.Models.ViewModels;
using Newtonsoft.Json;

namespace SmartWatch.Areas.StepCountt.Controllers
{
    [Area("StepCountt")]
    public class StepCountListController : Controller
    {
        public IActionResult Index()
        {
            List<Profile> profiles = new List<Profile>();
            using (SmartWatchContext db = new SmartWatchContext())
            {
                profiles = db.Profiles.Where(w=>w.ProfileIsDelete == false).ToList();
            }
            return View(profiles);
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



                    var userStepCount = db.StepCounts.Where(w => w.UserId == item.Role.UserId)
                        .Where(w => w.DeviceTime.Date == DateTime.Now.Date).Sum(s => s.Steps);

                    profileViewModel.Steps = userStepCount;

                    profileViewModels.Add(profileViewModel);

                }
                return Content(JsonConvert.SerializeObject(profileViewModels), "application/json");
            }
        }
    }


}
