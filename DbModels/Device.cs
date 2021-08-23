using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace SmartWatch.DbModels
{
    [Table("device")]
    public partial class Device
    {
        public Device()
        {
            DeviceAssigns = new HashSet<DeviceAssign>();
        }

        [Key]
        [Column("device_id")]
        public int DeviceId { get; set; }
        [Required]
        [Column("type")]
        [StringLength(50)]
        public string Type { get; set; }
        [Column("reg_date", TypeName = "datetime")]
        public DateTime RegDate { get; set; }
        [Required]
        [StringLength(250)]
        public string DeviceCode { get; set; }
        [Column("deviceIsDelete")]
        public bool DeviceIsDelete { get; set; }

        [InverseProperty(nameof(DeviceAssign.Device))]
        public virtual ICollection<DeviceAssign> DeviceAssigns { get; set; }
    }
}
