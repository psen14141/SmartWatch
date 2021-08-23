using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartWatch.DbModels;

namespace SmartWatch.Areas.Users.Models.ViewModels
{
    public class RoleViewModel
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public bool IsActive { get; set; }
        public bool IsSystem { get; set; }
        public bool IsSuperadmin { get; set; }
        public bool IsClientRoot { get; set; }
        public bool IsClient { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool RoleIsDelete { get; set; }
    }
}
