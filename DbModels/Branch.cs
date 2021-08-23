using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace SmartWatch.DbModels
{
    [Table("branch")]
    public partial class Branch
    {
        [Key]
        [Column("branch_id")]
        public int BranchId { get; set; }
        [Column("company_id")]
        public int CompanyId { get; set; }
        [Column("country_id")]
        public int CountryId { get; set; }
        [Column("branchCode")]
        public int BranchCode { get; set; }
        [Required]
        [Column("location")]
        [StringLength(50)]
        public string Location { get; set; }
        [Required]
        [Column("branch_name")]
        [StringLength(50)]
        public string BranchName { get; set; }
        [Required]
        [Column("address")]
        [StringLength(150)]
        public string Address { get; set; }
        [Required]
        [Column("phone")]
        [StringLength(50)]
        public string Phone { get; set; }
        [Column("branchIsDelete")]
        public bool BranchIsDelete { get; set; }

        [ForeignKey(nameof(CompanyId))]
        [InverseProperty("Branches")]
        public virtual Company Company { get; set; }
        [ForeignKey(nameof(CountryId))]
        [InverseProperty("Branches")]
        public virtual Country Country { get; set; }
    }
}
