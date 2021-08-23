using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartWatch.Areas.Users.Models.ViewModels;
using SmartWatch.DbModels;


namespace SmartWatch.Areas.Users.Controllers
{

    [Area("Users")]

    public class DoctorProfileController : Controller
    {
        public IActionResult Index()
        {


            List<ProfileViewModel> profileViewModels = new List<ProfileViewModel>();

            using (SmartWatchContext db = new SmartWatchContext())
            {
                var user = db.Users.Join
                   (db.Roles.Where(w => w.RoleName == "Doctor"),
                   roletype => roletype.RoleId,
                   userget => userget.RoleId,
                   (roletype, userget) => new { Role = roletype, User = userget }
                   );


                foreach (var item in user)
                {
                    ProfileViewModel profileViewModel = new ProfileViewModel();
                    profileViewModel.UserId = item.Role.UserId;
                    profileViewModel.Username = item.Role.Username.Trim();
                    profileViewModel.UserSecret = item.Role.UserSecret.Trim();
                    profileViewModel.UserDynamickey = item.Role.UserDynamickey.Trim();
                    profileViewModel.RoleId = item.Role.RoleId;
                    profileViewModel.RoleName = item.Role.Role.RoleName.Trim();
                    profileViewModel.ProfileId = item.Role.ProfileId;
                    profileViewModel.CreateTime = item.Role.CreateTime;
                    profileViewModel.Password = item.Role.Password;
                    profileViewModel.Email = item.Role.Email.Trim();
                    profileViewModel.Mobile = item.Role.Mobile;
                    profileViewModel.UserIsdelete = item.Role.UserIsdelete;
                    profileViewModels.Add(profileViewModel);
                }
                profileViewModels = profileViewModels.Where(w => w.UserIsdelete == false).ToList();
                

                return View(profileViewModels);
            }
        }

        public IActionResult AddorEdit(long Id)
        {

            ProfileViewModel profileViewModel = new ProfileViewModel();
            using (SmartWatchContext db = new SmartWatchContext())
            {
                if (Id != 0)
                {
                    DbModels.User user = db.Users.Where(w => w.UserId == Id).First();
                    profileViewModel.UserId = user.UserId;
                    profileViewModel.Username = user.Username.Trim();
                    profileViewModel.Email = user.Email.Trim();
                    profileViewModel.Password = user.Password;
                    profileViewModel.Mobile = user.Mobile;
                    profileViewModel.CreateTime = user.CreateTime;
                    profileViewModel.UserSecret = user.UserSecret.Trim();
                    profileViewModel.UserDynamickey = user.UserDynamickey.Trim();
                    profileViewModel.RoleId = user.RoleId;
                    profileViewModel.ProfileId = user.ProfileId;


                    DbModels.Profile profile = db.Profiles.Where(w => w.ProfileId == user.ProfileId).First();
                    profileViewModel.ProfileId = profile.ProfileId;
                    profileViewModel.CompanyId = profile.CompanyId;
                    profileViewModel.CountryId = profile.CountryId;
                    profileViewModel.FirstName = profile.FirstName.Trim();
                    profileViewModel.LastName = profile.LastName.Trim();
                    profileViewModel.Profilecol = profile.Profilecol.Trim();
                    profileViewModel.Mobile = profile.Mobile;
                    profileViewModel.Address = profile.Address.Trim();
                    profileViewModel.City = profile.City.Trim();
                    profileViewModel.PostalCode = profile.PostalCode;


                }
                else
                {

                }
                profileViewModel.RoleId = db.Roles.Where(y => y.RoleName == "Doctor").Select(x => x.RoleId).FirstOrDefault();
                profileViewModel.companies = db.Companies.ToList();
                profileViewModel.countries = db.Countries.ToList();
                profileViewModel.CreateTime = DateTime.Now;


            }
            return View(profileViewModel);
        }
        public IActionResult SaveProfileDoctor(ProfileViewModel profileviewmodel)
        {
            using (SmartWatchContext db = new SmartWatchContext())
            {

                Profile profile = new Profile();
                profile.ProfileId = profileviewmodel.ProfileId;
                profile.CompanyId = profileviewmodel.CompanyId;
                profile.CountryId = profileviewmodel.CountryId;
                profile.FirstName = profileviewmodel.FirstName.Trim();
                profile.LastName = profileviewmodel.LastName.Trim();
                profile.Profilecol = profileviewmodel.Profilecol.Trim();
                profile.Mobile = profileviewmodel.Mobile;
                profile.Address = profileviewmodel.Address.Trim();
                profile.City = profileviewmodel.City.Trim();
                profile.PostalCode = profileviewmodel.PostalCode.Trim();

                User user = new User();
                user.UserId = profileviewmodel.UserId;
                user.Username = profileviewmodel.Username.Trim();
                user.Email = profileviewmodel.Email.Trim();

                user.Password = SmartWatch.ProPlatform.Security.ProEncryptor.ToMD5Hash(profileviewmodel.Password);
                user.CreateTime = profileviewmodel.CreateTime;
                user.UserSecret = profileviewmodel.UserSecret;
                user.UserDynamickey = profileviewmodel.UserDynamickey;
                user.RoleId = profileviewmodel.RoleId;
                user.ProfileId = profileviewmodel.ProfileId;
                user.Mobile = profileviewmodel.Mobile;


                if (profile.ProfileId == 0)
                {
                    profile.Users.Add(user);

                    db.Profiles.Add(profile);

                }
                else
                {

                    DbModels.Profile dbprofile = db.Profiles.Where(w => w.ProfileId == profile.ProfileId).First();
                    dbprofile.ProfileId = profile.ProfileId;
                    dbprofile.CompanyId = profile.CompanyId;
                    dbprofile.CountryId = profile.CountryId;
                    dbprofile.FirstName = profile.FirstName.Trim();
                    dbprofile.LastName = profile.LastName.Trim();
                    dbprofile.Profilecol = profile.Profilecol.Trim();
                    dbprofile.Mobile = profile.Mobile;
                    dbprofile.Address = profile.Address.Trim();
                    dbprofile.City = profile.City.Trim();
                    dbprofile.PostalCode = profile.PostalCode.Trim();

                    DbModels.User dbuser = db.Users.Where(w => w.UserId == user.UserId).First();
                    dbuser.UserId = user.UserId;
                    dbuser.Username = user.Username.Trim();
                    dbuser.Email = user.Email.Trim();
                    dbuser.Password = SmartWatch.ProPlatform.Security.ProEncryptor.ToMD5Hash(user.Password); 
                    dbuser.CreateTime = user.CreateTime;
                    dbuser.UserSecret = user.UserSecret;
                    dbuser.UserDynamickey = user.UserDynamickey;
                    dbuser.RoleId = user.RoleId;
                    dbuser.Mobile = user.Mobile;
                }

                db.SaveChanges();
            }

            return Redirect("/Users/DoctorProfile/Index");
        }


        public IActionResult EditDoctor(long Id)
        {

            ProfileViewModel profileViewModel = new ProfileViewModel();
            using (SmartWatchContext db = new SmartWatchContext())
            {
                if (Id != 0)
                {
                    DbModels.User user = db.Users.Where(w => w.UserId == Id).First();
                    profileViewModel.UserId = user.UserId;
                    profileViewModel.Username = user.Username.Trim();
                    profileViewModel.Email = user.Email.Trim();
                    profileViewModel.Password = user.Password;
                    profileViewModel.Mobile = user.Mobile;
                    profileViewModel.CreateTime = user.CreateTime;
                    profileViewModel.UserSecret = user.UserSecret;
                    profileViewModel.UserDynamickey = user.UserDynamickey;
                    profileViewModel.RoleId = user.RoleId;
                    profileViewModel.ProfileId = user.ProfileId;


                    DbModels.Profile profile = db.Profiles.Where(w => w.ProfileId == user.ProfileId).First();
                    profileViewModel.ProfileId = profile.ProfileId;
                    profileViewModel.CompanyId = profile.CompanyId;
                    profileViewModel.CountryId = profile.CountryId;
                    profileViewModel.FirstName = profile.FirstName.Trim();
                    profileViewModel.LastName = profile.LastName.Trim();
                    profileViewModel.Profilecol = profile.Profilecol.Trim();
                    profileViewModel.Mobile = profile.Mobile;
                    profileViewModel.Address = profile.Address.Trim();
                    profileViewModel.City = profile.City.Trim();
                    profileViewModel.PostalCode = profile.PostalCode.Trim();


                }
                else
                {

                }
                profileViewModel.RoleId = db.Roles.Where(y => y.RoleName == "Doctor").Select(x => x.RoleId).FirstOrDefault();
                profileViewModel.companies = db.Companies.ToList();
                profileViewModel.countries = db.Countries.ToList();
                profileViewModel.CreateTime = DateTime.Now;


            }
            return View(profileViewModel);
        }

        public IActionResult EditSaveProfileDoctor(ProfileViewModel profileviewmodel)
        {
            using (SmartWatchContext db = new SmartWatchContext())
            {

                Profile profile = new Profile();
                profile.ProfileId = profileviewmodel.ProfileId;
                profile.CompanyId = profileviewmodel.CompanyId;
                profile.CountryId = profileviewmodel.CountryId;
                profile.FirstName = profileviewmodel.FirstName.Trim();
                profile.LastName = profileviewmodel.LastName.Trim();
                profile.Profilecol = profileviewmodel.Profilecol.Trim();
                profile.Mobile = profileviewmodel.Mobile;
                profile.Address = profileviewmodel.Address.Trim();
                profile.City = profileviewmodel.City.Trim();
                profile.PostalCode = profileviewmodel.PostalCode.Trim();

                User user = new User();
                user.UserId = profileviewmodel.UserId;
                user.Username = profileviewmodel.Username.Trim();
                user.Email = profileviewmodel.Email.Trim();
                user.CreateTime = profileviewmodel.CreateTime;
                user.UserSecret = profileviewmodel.UserSecret;
                user.UserDynamickey = profileviewmodel.UserDynamickey.Trim();
                user.RoleId = profileviewmodel.RoleId;
                user.ProfileId = profileviewmodel.ProfileId;
                user.Mobile = profileviewmodel.Mobile;


                if (profile.ProfileId != 0)
                {
                    DbModels.Profile dbprofile = db.Profiles.Where(w => w.ProfileId == profile.ProfileId).First();
                    dbprofile.ProfileId = profile.ProfileId;
                    dbprofile.CompanyId = profile.CompanyId;
                    dbprofile.CountryId = profile.CountryId;
                    dbprofile.FirstName = profile.FirstName.Trim();
                    dbprofile.LastName = profile.LastName.Trim();
                    dbprofile.Profilecol = profile.Profilecol.Trim();
                    dbprofile.Mobile = profile.Mobile;
                    dbprofile.Address = profile.Address.Trim();
                    dbprofile.City = profile.City.Trim();
                    dbprofile.PostalCode = profile.PostalCode.Trim();

                    DbModels.User dbuser = db.Users.Where(w => w.UserId == user.UserId).First();
                    dbuser.UserId = user.UserId;
                    dbuser.Username = user.Username.Trim();
                    dbuser.Email = user.Email.Trim();
                    dbuser.CreateTime = user.CreateTime;
                    dbuser.UserSecret = user.UserSecret;
                    dbuser.UserDynamickey = user.UserDynamickey.Trim();
                    dbuser.RoleId = user.RoleId;
                    dbuser.Mobile = user.Mobile;
                }

                db.SaveChanges();
            }

            return Redirect("/Users/DoctorProfile/Index");
        }




        public IActionResult Delete(long Id)
        {
            using (SmartWatchContext db = new SmartWatchContext())
            {

                DbModels.User userdelete = db.Users.Where(w => w.UserId == Id).FirstOrDefault();
                if (userdelete != null)
                {
                    userdelete.UserIsdelete = true;
                    
                }
                db.SaveChanges();

            }

            return Redirect("/Users/DoctorProfile/Index");
        }
    }
}

