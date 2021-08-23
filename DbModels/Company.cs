using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace SmartWatch.DbModels
{
    [Table("company")]
    public partial class Company
    {
        public Company()
        {
            Branches = new HashSet<Branch>();
            Profiles = new HashSet<Profile>();
            Timestamps = new HashSet<Timestamp>();
        }

        [Key]
        [Column("company_id")]
        public int CompanyId { get; set; }
        [Required]
        [Column("name")]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [Column("reg_no")]
        [StringLength(50)]
        public string RegNo { get; set; }
        [Required]
        [Column("phone")]
        [StringLength(50)]
        public string Phone { get; set; }
        [Column("logo")]
        [StringLength(150)]
        public string Logo { get; set; }
        [Column("country_id")]
        public int CountryId { get; set; }
        [Required]
        [StringLength(100)]
        public string CompanyBranchColor { get; set; }
        [Required]
        [StringLength(50)]
        public string CompanyForColor { get; set; }
        public bool CompanyIsDelete { get; set; }

        [ForeignKey(nameof(CountryId))]
        [InverseProperty("Companies")]
        public virtual Country Country { get; set; }
        [InverseProperty(nameof(Branch.Company))]
        public virtual ICollection<Branch> Branches { get; set; }
        [InverseProperty(nameof(Profile.Company))]
        public virtual ICollection<Profile> Profiles { get; set; }
        [InverseProperty(nameof(Timestamp.Company))]
        public virtual ICollection<Timestamp> Timestamps { get; set; }
    }
}
