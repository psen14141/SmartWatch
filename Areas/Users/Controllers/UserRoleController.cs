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
    public class UserRoleController : Controller
    {
        public IActionResult Index()
        {
            List<Role> roles = new List<Role>();
            using(SmartWatchContext db = new SmartWatchContext())
            {
                roles = db.Roles.ToList();
            }
            roles = roles.Where(w => w.RoleIsDelete == false).ToList();
            return View(roles);
        }

        public IActionResult AddorEdit(long Id)
        {
            RoleViewModel roleViewModel = new RoleViewModel();

            using (SmartWatchContext db = new SmartWatchContext())
            {
                if (Id != 0)
                {
                    DbModels.Role role = db.Roles.Where(w => w.RoleId == Id).First();
                    roleViewModel.RoleId = role.RoleId;
                    roleViewModel.RoleName = role.RoleName.Trim();
                    roleViewModel.IsActive = role.IsActive;
                    roleViewModel.IsSystem = role.IsSystem;
                    roleViewModel.IsSuperadmin = role.IsSuperadmin;
                    roleViewModel.IsClientRoot = role.IsClientRoot;
                    roleViewModel.IsClient = role.IsClient;
                    roleViewModel.CreatedAt = role.CreatedAt;
                    roleViewModel.UpdatedAt = role.UpdatedAt;

                }
                else
                {
                    roleViewModel.CreatedAt = DateTime.Now;
                    roleViewModel.UpdatedAt = DateTime.Now;
                }
            }
            return View(roleViewModel);
        }

        public IActionResult SaveRole(DbModels.Role role)
        {
            using (SmartWatchContext db = new SmartWatchContext())
            {

                if (role.RoleId == 0)
                {
                    db.Roles.Add(role);
                }

                else
                {
                    DbModels.Role dbrolesave = db.Roles.Where(w => w.RoleId == role.RoleId).First();

                    dbrolesave.RoleId = role.RoleId;
                    dbrolesave.RoleName = role.RoleName.Trim();
                    dbrolesave.IsActive = role.IsActive;
                    dbrolesave.IsSystem = role.IsSystem;
                    dbrolesave.IsSuperadmin = role.IsSuperadmin;
                    dbrolesave.IsClientRoot = role.IsClientRoot;
                    dbrolesave.IsClient = role.IsClient;
                    dbrolesave.CreatedAt = role.CreatedAt;
                    dbrolesave.UpdatedAt = role.UpdatedAt;
                }
                db.SaveChanges();
            }

            return Redirect("/Users/UserRole/Index");
        }

        public IActionResult Delete(int Id)
        {
            using (SmartWatchContext db = new SmartWatchContext())
            {

                DbModels.Role roleDelete = db.Roles.Where(w => w.RoleId == Id).First();
                if (roleDelete != null)
                {
                    roleDelete.RoleIsDelete = true;
                }
                db.SaveChanges();
            }

            return Redirect("/Users/UserRole/Index");
        }
    }
}
