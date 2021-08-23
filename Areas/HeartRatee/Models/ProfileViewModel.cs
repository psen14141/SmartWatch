using SmartWatch.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartWatch.Areas.HeartRatee.Models
{
    public class ProfileViewModel
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
        public string Webapplicationtoken { get; set; }

        public string Mobiledevicetoken { get; set; }


        public int CompanyId { get; set; }
        public int CountryId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Profilecol { get; set; }

        public string Address { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public bool ProfileIsDelete { get; set; }

        public List<Role> roletypes { get; set; } = new List<Role>();
        public List<Profile> profiles { get; set; } = new List<Profile>();

        public List<Company> companies { get; set; } = new List<Company>();

        public List<Country> countries { get; set; } = new List<Country>();
        public List<BloodPressure> bloodPressure { get; set; } = new List<BloodPressure>();

        public double bloodPressureUpper { get; set; }
        public double bloodPressureLower { get; set; }

        public DateTime checkedTime { get; set; }

        public double PulseRate { get; set; }
        public long Steps { get; set; }
        public double Temperature { get; set; }
    }
}
