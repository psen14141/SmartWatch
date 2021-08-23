using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace SmartWatch.DbModels
{
    [Table("profile")]
    public partial class Profile
    {
        public Profile()
        {
            Timestamps = new HashSet<Timestamp>();
            Users = new HashSet<User>();
        }

        [Key]
        public int ProfileId { get; set; }
        [Column("company_id")]
        public int CompanyId { get; set; }
        [Column("country_id")]
        public int CountryId { get; set; }
        [Required]
        [Column("first_name")]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required]
        [Column("last_name")]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required]
        [Column("profilecol")]
        [StringLength(50)]
        public string Profilecol { get; set; }
        [Column("mobile")]
        public int Mobile { get; set; }
        [Required]
        [Column("address")]
        [StringLength(50)]
        public string Address { get; set; }
        [Required]
        [Column("city")]
        [StringLength(50)]
        public string City { get; set; }
        [Required]
        [Column("postal_code")]
        [StringLength(50)]
        public string PostalCode { get; set; }
        [Column("profileIsDelete")]
        public bool ProfileIsDelete { get; set; }

        [ForeignKey(nameof(CompanyId))]
        [InverseProperty("Profiles")]
        public virtual Company Company { get; set; }
        [ForeignKey(nameof(CountryId))]
        [InverseProperty("Profiles")]
        public virtual Country Country { get; set; }
        [InverseProperty(nameof(Timestamp.Profile))]
        public virtual ICollection<Timestamp> Timestamps { get; set; }
        [InverseProperty(nameof(User.Profile))]
        public virtual ICollection<User> Users { get; set; }
    }
}
