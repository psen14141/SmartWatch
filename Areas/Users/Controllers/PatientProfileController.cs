using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SmartWatch.Areas.Users.Models.ViewModels;
using SmartWatch.DbModels;

namespace SmartWatch.Areas.Users.Controllers
{
    [Area("Users")]

    public class PatientProfileController : Controller
    {
        public IActionResult Index()
        {

            List<ProfileViewModel> profileViewModels = new List<ProfileViewModel>();

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
                    profileViewModel.Username = item.Role.Username.Trim();
                    profileViewModel.UserSecret = item.Role.UserSecret.Trim();
                    profileViewModel.UserDynamickey = item.Role.UserDynamickey.Trim();
                    profileViewModel.RoleId = item.Role.RoleId;
                    profileViewModel.RoleName = item.Role.Role.RoleName.Trim();
                    profileViewModel.ProfileId = item.Role.ProfileId;
                    profileViewModel.CreateTime = item.Role.CreateTime;
                    profileViewModel.Password = item.Role.Password.Trim();
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
                    profileViewModel.PostalCode = profile.PostalCode.Trim();


                }
                else
                {

                }
                profileViewModel.RoleId = db.Roles.Where(y => y.RoleName == "Patient").Select(x => x.RoleId).FirstOrDefault();
                profileViewModel.companies = db.Companies.ToList();
                profileViewModel.countries = db.Countries.ToList();
                profileViewModel.CreateTime = DateTime.Now;


            }
            return View(profileViewModel);
        }

        public IActionResult SaveProfilePatient(ProfileViewModel profileviewmodel)
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
                user.UserSecret = profileviewmodel.UserSecret.Trim();
                user.UserDynamickey = profileviewmodel.UserDynamickey.Trim();
                user.RoleId = profileviewmodel.RoleId;
                user.ProfileId = profileviewmodel.ProfileId;
                user.Mobile = profileviewmodel.Mobile;
                user.RoleId = user.RoleId;
                user.Profile = profile;
               // profile.Users.Add(user);

                db.Users.Add(user);
                db.SaveChanges();
            }

            return Redirect("/Users/PatientProfile/Index");
        }

        public IActionResult EditPatient(long Id)
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
                    profileViewModel.Profilecol = profile.Profilecol;
                    profileViewModel.Mobile = profile.Mobile;
                    profileViewModel.Address = profile.Address.Trim();
                    profileViewModel.City = profile.City.Trim();
                    profileViewModel.PostalCode = profile.PostalCode.Trim();


                }
                else
                {

                }
                profileViewModel.RoleId = db.Roles.Where(y => y.RoleName == "Patient").Select(x => x.RoleId).FirstOrDefault();
                profileViewModel.companies = db.Companies.ToList();
                profileViewModel.countries = db.Countries.ToList();
                profileViewModel.CreateTime = DateTime.Now;


            }
            return View(profileViewModel);
        }

        public IActionResult EditSaveProfilePatient(ProfileViewModel profileviewmodel)
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
                user.UserSecret = profileviewmodel.UserSecret.Trim();
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
                    dbuser.UserSecret = user.UserSecret.Trim();
                    dbuser.UserDynamickey = user.UserDynamickey.Trim();
                    dbuser.RoleId = user.RoleId;
                    dbuser.Mobile = user.Mobile;
                }

                db.SaveChanges();
            }

            return Redirect("/Users/PatientProfile/Index");
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

            return Redirect("/Users/PatientProfile/Index");
        }

        public IActionResult PatientAssign()
        {
            List<PatientAssignViewModel> patientAssignViewModels = new List<PatientAssignViewModel>();
            using (SmartWatchContext db = new SmartWatchContext())
            {
                var passign = db.PatientAssigns.Join
                   (db.Users.Where(w => w.Role.RoleName == "Patient"),
                   passigns => passigns.PatientId,
                   user => user.UserId,
                   (passigns, user) => new { PatientAssign = passigns, User = user }
                   );

                var sassign = passign.Join
                   (db.Users.Where(w => w.Role.RoleName == "Doctor" || w.Role.RoleName == "Nurse"),
                   sassigns => sassigns.PatientAssign.AssignedStaffId,
                   user => user.UserId,
                   (sassigns, user) => new { PatientAssign = sassigns, User = user }
                   );

                foreach (var assign in sassign)
                {
                   PatientAssignViewModel patientAssignViewModels1 = new PatientAssignViewModel();
                    patientAssignViewModels1.PatientAssignId = assign.PatientAssign.PatientAssign.PatientAssignId;
                    patientAssignViewModels1.PatientId = assign.PatientAssign.PatientAssign.PatientId;
                    patientAssignViewModels1.AssignedStaffId = assign.PatientAssign.PatientAssign.AssignedStaffId;
                    patientAssignViewModels1.PatientAssignedStartDate = assign.PatientAssign.PatientAssign.PatientAssignedStartDate;
                    patientAssignViewModels1.PatientAssignedEndDate = assign.PatientAssign.PatientAssign.PatientAssignedEndDate;
                    patientAssignViewModels1.PatientAssignedIsDelete = assign.PatientAssign.PatientAssign.PatientAssignedIsDelete;
                    patientAssignViewModels1.Username = assign.User.Username;
                    //patientAssignViewModels1.RoleId = assign.User.RoleId;
                    patientAssignViewModels.Add(patientAssignViewModels1);
                }            
                    patientAssignViewModels = patientAssignViewModels.Where(w => w.PatientAssignedIsDelete == false).ToList();               
            }
            return View(patientAssignViewModels);
        }

        public IActionResult PatientAssignEdit(int Id)
        {
            PatientAssignViewModel patientAssignViewModel = new PatientAssignViewModel();
            using (SmartWatchContext db = new SmartWatchContext())
            {
                if(Id != 0)
                {
                    PatientAssign patientAssign = db.PatientAssigns.Where(w => w.PatientAssignId == Id).FirstOrDefault();
                    patientAssignViewModel.PatientAssignId = patientAssign.PatientAssignId;
                    patientAssignViewModel.PatientId = patientAssign.PatientId;
                    patientAssignViewModel.AssignedStaffId = patientAssign.AssignedStaffId;
                    patientAssignViewModel.PatientAssignedStartDate = patientAssign.PatientAssignedStartDate;
                    patientAssignViewModel.PatientAssignedEndDate = patientAssign.PatientAssignedEndDate;
                    patientAssignViewModel.PatientAssignedIsDelete = patientAssign.PatientAssignedIsDelete;
                    patientAssignViewModel.users = db.Users.ToList();
                }
                    patientAssignViewModel.users = db.Users.ToList();
            }
            return View(patientAssignViewModel);
        }

        public IActionResult AssignSave(PatientAssign patientAssign)
        {
            using (SmartWatchContext db = new SmartWatchContext())
            {
                if(patientAssign.PatientAssignId == 0)
                {
                    db.PatientAssigns.Add(patientAssign);
                }
                else
                {
                    PatientAssign patientAssign1 = db.PatientAssigns.Where(w => w.PatientAssignId == patientAssign.PatientAssignId).FirstOrDefault();
                    patientAssign1.PatientAssignId = patientAssign.PatientAssignId;
                    patientAssign1.PatientId = patientAssign.PatientId;
                    patientAssign1.AssignedStaffId = patientAssign.AssignedStaffId;
                    patientAssign1.PatientAssignedStartDate = patientAssign.PatientAssignedStartDate;
                    patientAssign1.PatientAssignedEndDate = patientAssign.PatientAssignedEndDate;
                    patientAssign1.PatientAssignedIsDelete = patientAssign.PatientAssignedIsDelete;
                }
                db.SaveChanges();
            }
            return Redirect("/Users/PatientProfile/PatientAssign");
        }
    }
}


