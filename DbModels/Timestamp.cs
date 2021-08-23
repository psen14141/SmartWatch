using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace SmartWatch.DbModels
{
    [Table("timestamps")]
    public partial class Timestamp
    {
        [Key]
        [Column("timestamps_id")]
        public int TimestampsId { get; set; }
        [Column("create_time", TypeName = "datetime")]
        public DateTime CreateTime { get; set; }
        [Column("update_time", TypeName = "datetime")]
        public DateTime UpdateTime { get; set; }
        [Column("deleted_time", TypeName = "datetime")]
        public DateTime DeletedTime { get; set; }
        [Required]
        [Column("ip_address")]
        [StringLength(50)]
        public string IpAddress { get; set; }
        [Column("profile_id")]
        public int ProfileId { get; set; }
        [Column("company_id")]
        public int CompanyId { get; set; }

        [ForeignKey(nameof(CompanyId))]
        [InverseProperty("Timestamps")]
        public virtual Company Company { get; set; }
        [ForeignKey(nameof(ProfileId))]
        [InverseProperty("Timestamps")]
        public virtual Profile Profile { get; set; }
    }
}
