using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace SmartWatch.DbModels
{
    [Table("PatientAssign")]
    public partial class PatientAssign
    {
        [Key]
        public int PatientAssignId { get; set; }
        public int PatientId { get; set; }
        public int AssignedStaffId { get; set; }
        [Column(TypeName = "date")]
        public DateTime PatientAssignedStartDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? PatientAssignedEndDate { get; set; }
        public bool PatientAssignedIsDelete { get; set; }

        [ForeignKey(nameof(AssignedStaffId))]
        [InverseProperty(nameof(User.PatientAssignAssignedStaffs))]
        public virtual User AssignedStaff { get; set; }
        [ForeignKey(nameof(PatientId))]
        [InverseProperty(nameof(User.PatientAssignPatients))]
        public virtual User Patient { get; set; }
    }
}
