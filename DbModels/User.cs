using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace SmartWatch.DbModels
{
    [Table("user")]
    public partial class User
    {
        public User()
        {
            BloodPressures = new HashSet<BloodPressure>();
            BodyTemperatures = new HashSet<BodyTemperature>();
            DeviceAssigns = new HashSet<DeviceAssign>();
            HealthAlerts = new HashSet<HealthAlert>();
            HeartRates = new HashSet<HeartRate>();
            PatientAssignAssignedStaffs = new HashSet<PatientAssign>();
            PatientAssignPatients = new HashSet<PatientAssign>();
            StepCounts = new HashSet<StepCount>();
            TriggerWarnings = new HashSet<TriggerWarning>();
            UserConfigurations = new HashSet<UserConfiguration>();
            UserSequences = new HashSet<UserSequence>();
        }

        [Key]
        [Column("userId")]
        public int UserId { get; set; }
        [Required]
        [Column("username")]
        [StringLength(50)]
        public string Username { get; set; }
        [Required]
        [Column("email")]
        [StringLength(150)]
        public string Email { get; set; }
        [Required]
        [Column("password")]
        [StringLength(45)]
        public string Password { get; set; }
        [Column("create_time", TypeName = "datetime")]
        public DateTime CreateTime { get; set; }
        [Column("mobile")]
        public int Mobile { get; set; }
        [Required]
        [Column("user_secret")]
        [StringLength(250)]
        public string UserSecret { get; set; }
        [Required]
        [Column("user_dynamickey")]
        [StringLength(250)]
        public string UserDynamickey { get; set; }
        [Column("role_id")]
        public int RoleId { get; set; }
        [Column("profile_id")]
        public int ProfileId { get; set; }
        [Column("user_isdelete")]
        public bool UserIsdelete { get; set; }
        [Column("webapplicationtoken")]
        [StringLength(250)]
        public string Webapplicationtoken { get; set; }
        [Column("mobiledevicetoken")]
        [StringLength(250)]
        public string Mobiledevicetoken { get; set; }

        [ForeignKey(nameof(ProfileId))]
        [InverseProperty("Users")]
        public virtual Profile Profile { get; set; }
        [ForeignKey(nameof(RoleId))]
        [InverseProperty("Users")]
        public virtual Role Role { get; set; }
        [InverseProperty(nameof(BloodPressure.User))]
        public virtual ICollection<BloodPressure> BloodPressures { get; set; }
        [InverseProperty(nameof(BodyTemperature.User))]
        public virtual ICollection<BodyTemperature> BodyTemperatures { get; set; }
        [InverseProperty(nameof(DeviceAssign.User))]
        public virtual ICollection<DeviceAssign> DeviceAssigns { get; set; }
        [InverseProperty(nameof(HealthAlert.User))]
        public virtual ICollection<HealthAlert> HealthAlerts { get; set; }
        [InverseProperty(nameof(HeartRate.User))]
        public virtual ICollection<HeartRate> HeartRates { get; set; }
        [InverseProperty(nameof(PatientAssign.AssignedStaff))]
        public virtual ICollection<PatientAssign> PatientAssignAssignedStaffs { get; set; }
        [InverseProperty(nameof(PatientAssign.Patient))]
        public virtual ICollection<PatientAssign> PatientAssignPatients { get; set; }
        [InverseProperty(nameof(StepCount.User))]
        public virtual ICollection<StepCount> StepCounts { get; set; }
        [InverseProperty(nameof(TriggerWarning.Profile))]
        public virtual ICollection<TriggerWarning> TriggerWarnings { get; set; }
        [InverseProperty(nameof(UserConfiguration.User))]
        public virtual ICollection<UserConfiguration> UserConfigurations { get; set; }
        [InverseProperty(nameof(UserSequence.User))]
        public virtual ICollection<UserSequence> UserSequences { get; set; }
    }
}
