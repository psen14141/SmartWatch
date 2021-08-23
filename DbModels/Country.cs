using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace SmartWatch.DbModels
{
    [Table("country")]
    public partial class Country
    {
        public Country()
        {
            Branches = new HashSet<Branch>();
            Companies = new HashSet<Company>();
            Profiles = new HashSet<Profile>();
        }

        [Key]
        [Column("country_code")]
        public int CountryCode { get; set; }
        [Required]
        [Column("country")]
        [StringLength(50)]
        public string Country1 { get; set; }
        public int TimeDifferenceHour { get; set; }
        public int TimeDifferenceMinute { get; set; }
        public bool CountryIsDelete { get; set; }
        [Required]
        [StringLength(10)]
        public string CountryCodes { get; set; }

        [InverseProperty(nameof(Branch.Country))]
        public virtual ICollection<Branch> Branches { get; set; }
        [InverseProperty(nameof(Company.Country))]
        public virtual ICollection<Company> Companies { get; set; }
        [InverseProperty(nameof(Profile.Country))]
        public virtual ICollection<Profile> Profiles { get; set; }
    }
}
