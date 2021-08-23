using SmartWatch.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartWatch.Areas.Users.Models.ViewModels
{
    public class PatientAssignViewModel
    {
            public int PatientAssignId { get; set; }
            public int PatientId { get; set; }
            public int AssignedStaffId { get; set; }
            public DateTime PatientAssignedStartDate { get; set; }
            public DateTime? PatientAssignedEndDate { get; set; }
            public bool PatientAssignedIsDelete { get; set; }
            public string Username { get; set; }
            public int UserId { get; set; }
            public virtual User AssignedStaff { get; set; }
            public virtual User Patient { get; set; }
            public int RoleId { get; set; }
            public string RoleName { get; set; }
            public List<DbModels.User> users { get; set; } = new List<DbModels.User>();
            public List<Role> role { get; set; } = new List<Role>();
    }
}
