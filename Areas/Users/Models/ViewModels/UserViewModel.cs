using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartWatch.DbModels;

namespace SmartWatch.Areas.Users.Models.ViewModels
{
    public class UserViewModel
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreateTime { get; set; }
        public int Mobile { get; set; }
        public string UserSecret { get; set; }
        public string UserDynamickey { get; set; }
        public int RoleId { get; set; }
        public int ProfileId { get; set; }
        public bool UserIsdelete { get; set; }

        public string RoleName { get; set; }

        public List<Role> roletypes { get; set; } = new List<Role>();
        public List<Profile> profiles { get; set; } = new List<Profile>();


    }
}
