using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace SmartWatch.DbModels
{
    public partial class SmartWatchContext : DbContext
    {
        public SmartWatchContext()
        {
        }

        public SmartWatchContext(DbContextOptions<SmartWatchContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AlertBox> AlertBoxes { get; set; }
        public virtual DbSet<AssignGroup> AssignGroups { get; set; }
        public virtual DbSet<BloodPressure> BloodPressures { get; set; }
        public virtual DbSet<BodyTemperature> BodyTemperatures { get; set; }
        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Configuration> Configurations { get; set; }
        public virtual DbSet<ConnectionStatus> ConnectionStatuses { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Device> Devices { get; set; }
        public virtual DbSet<DeviceAssign> DeviceAssigns { get; set; }
        public virtual DbSet<HealthAlert> HealthAlerts { get; set; }
        public virtual DbSet<HeartRate> HeartRates { get; set; }
        public virtual DbSet<Illness> Illnesses { get; set; }
        public virtual DbSet<Measuring> Measurings { get; set; }
        public virtual DbSet<MessageGroup> MessageGroups { get; set; }
        public virtual DbSet<Module> Modules { get; set; }
        public virtual DbSet<PatientAssign> PatientAssigns { get; set; }
        public virtual DbSet<Permission> Permissions { get; set; }
        public virtual DbSet<Profile> Profiles { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<StepCount> StepCounts { get; set; }
        public virtual DbSet<Symptom> Symptoms { get; set; }
        public virtual DbSet<SymptomIllness> SymptomIllnesses { get; set; }
        public virtual DbSet<Timestamp> Timestamps { get; set; }
        public virtual DbSet<TriggerWarning> TriggerWarnings { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserConfiguration> UserConfigurations { get; set; }
        public virtual DbSet<UserSequence> UserSequences { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                //                optionsBuilder.UseSqlServer("Data Source=DESKTOP-1H7H1RK;Initial Catalog=SmartWatch;User ID=sa;Password=abc123;Trusted_Connection=True;MultipleActiveResultSets=True;");

                //pamoda
                // optionsBuilder.UseSqlServer("Data Source=DESKTOP-1H7H1RK;Initial Catalog=SmartWatch1;User ID=sa;Password=abc123;Trusted_Connection=True;MultipleActiveResultSets=True;");

                //Dushan
                //optionsBuilder.UseSqlServer("Data Source=DESKTOP-RV3BD9R\\SQLEXPRESS;Initial Catalog=SmartWatch;User ID=sa;Password=abc123;Trusted_Connection=True;MultipleActiveResultSets=True;");

                //Kalpa
               optionsBuilder.UseSqlServer("Data Source=OFFICEROOM\\EXP2019;Initial Catalog=SmartWatch1;User ID=sa;Password=abc123;Trusted_Connection=True;MultipleActiveResultSets=True;");

                //Osura
                //optionsBuilder.UseSqlServer("Data Source=DESKTOP-B9ERMS4\\SQLEXPRESS;Initial Catalog=SmartWatch1;User ID=sa;Password=abc123;Trusted_Connection=True;MultipleActiveResultSets=True;");

                //Miyuru
                //optionsBuilder.UseSqlServer("Data Source=DESKTOP-P09PA9J\\SQLEXPRESS;Initial Catalog=SmartWatch1;User ID=sa;Password=abc123;Trusted_Connection=True;MultipleActiveResultSets=True;");

                //Shehan
                //optionsBuilder.UseSqlServer("Data Source=DESKTOP-ET97L69\\SQLEXPRESS;Initial Catalog=SmartWatch1;User ID=sa;Password=abc123;Trusted_Connection=True;MultipleActiveResultSets=True;");

                //Vidura
                //optionsBuilder.UseSqlServer("Data Source=LAPTOP-0V40PCDN\\SQLEXPRESS;Initial Catalog=SmartWatch1;User ID=sa;Password=abc123;Trusted_Connection=True;MultipleActiveResultSets=True;");

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AlertBox>(entity =>
            {
                entity.Property(e => e.MessageBody).IsUnicode(false);

                entity.Property(e => e.Title).IsUnicode(false);

                entity.HasOne(d => d.MessageGroup)
                    .WithMany(p => p.AlertBoxes)
                    .HasForeignKey(d => d.MessageGroupid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("message-group_alartbox");
            });

            modelBuilder.Entity<AssignGroup>(entity =>
            {
                entity.Property(e => e.AssignId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.Group)
                    .WithMany()
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("message-group_assign-group");

                entity.HasOne(d => d.User)
                    .WithMany()
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("user_assign-group");
            });

            modelBuilder.Entity<BloodPressure>(entity =>
            {
                entity.HasOne(d => d.Connection)
                    .WithMany(p => p.BloodPressures)
                    .HasForeignKey(d => d.ConnectionId)
                    .HasConstraintName("FK_BloodPressure_device-assign");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.BloodPressures)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BloodPressure_user");
            });

            modelBuilder.Entity<BodyTemperature>(entity =>
            {
                entity.HasOne(d => d.Connect)
                    .WithMany(p => p.BodyTemperatures)
                    .HasForeignKey(d => d.ConnectId)
                    .HasConstraintName("device-assign_body_temperature");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.BodyTemperatures)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("user_body_temperture");
            });

            modelBuilder.Entity<Branch>(entity =>
            {
                entity.Property(e => e.Address).IsUnicode(false);

                entity.Property(e => e.BranchName).IsUnicode(false);

                entity.Property(e => e.Location).IsUnicode(false);

                entity.Property(e => e.Phone)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Branches)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("company_branch");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Branches)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("country_branch");
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.Property(e => e.CompanyBranchColor).IsUnicode(false);

                entity.Property(e => e.CompanyForColor).IsUnicode(false);

                entity.Property(e => e.Logo).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Phone).IsUnicode(false);

                entity.Property(e => e.RegNo).IsUnicode(false);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Companies)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Country_Company");
            });

            modelBuilder.Entity<Configuration>(entity =>
            {
                entity.Property(e => e.ConfigurationString).IsUnicode(false);

                entity.Property(e => e.StringValue).IsUnicode(false);
            });

            modelBuilder.Entity<ConnectionStatus>(entity =>
            {
                entity.Property(e => e.Status).IsUnicode(false);

                entity.HasOne(d => d.Connect)
                    .WithMany(p => p.ConnectionStatuses)
                    .HasForeignKey(d => d.ConnectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("device-assign_connection-status");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.HasKey(e => e.CountryCode)
                    .HasName("PK_Country");

                entity.Property(e => e.Country1).IsUnicode(false);

                entity.Property(e => e.CountryCodes)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Device>(entity =>
            {
                entity.Property(e => e.DeviceCode).IsUnicode(false);

                entity.Property(e => e.Type).IsUnicode(false);
            });

            modelBuilder.Entity<DeviceAssign>(entity =>
            {
                entity.HasOne(d => d.Device)
                    .WithMany(p => p.DeviceAssigns)
                    .HasForeignKey(d => d.DeviceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("device_devise-assign");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.DeviceAssigns)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("user_device-assign");
            });

            modelBuilder.Entity<HealthAlert>(entity =>
            {
                entity.Property(e => e.Healthstatus).IsUnicode(false);

                entity.Property(e => e.ReceiverAlert).IsUnicode(false);

                entity.Property(e => e.Response).IsUnicode(false);

                entity.HasOne(d => d.Trigger)
                    .WithMany(p => p.HealthAlerts)
                    .HasForeignKey(d => d.TriggerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("trigger-warning_health-alert");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.HealthAlerts)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("user_health-alert");
            });

            modelBuilder.Entity<HeartRate>(entity =>
            {
                entity.HasKey(e => e.RecId)
                    .HasName("PK_hart_rate");

                entity.HasOne(d => d.Connection)
                    .WithMany(p => p.HeartRates)
                    .HasForeignKey(d => d.ConnectionId)
                    .HasConstraintName("device-assign_heart_rate");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.HeartRates)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("user_heart_rate");
            });

            modelBuilder.Entity<Illness>(entity =>
            {
                entity.Property(e => e.IllNessName).IsUnicode(false);

                entity.Property(e => e.IllnessDescription).IsUnicode(false);
            });

            modelBuilder.Entity<Measuring>(entity =>
            {
                entity.Property(e => e.MeasuringDescription).IsUnicode(false);

                entity.Property(e => e.MeasuringName).IsUnicode(false);
            });

            modelBuilder.Entity<MessageGroup>(entity =>
            {
                entity.Property(e => e.GroupIsDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<Module>(entity =>
            {
                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.ShortCode).IsUnicode(false);

                entity.Property(e => e.System).IsUnicode(false);

                entity.Property(e => e.WorkshopId).IsUnicode(false);
            });

            modelBuilder.Entity<PatientAssign>(entity =>
            {
                entity.Property(e => e.PatientAssignedStartDate).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.AssignedStaff)
                    .WithMany(p => p.PatientAssignAssignedStaffs)
                    .HasForeignKey(d => d.AssignedStaffId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PatientAssign_user1");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.PatientAssignPatients)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PatientAssign_user");
            });

            modelBuilder.Entity<Permission>(entity =>
            {
                entity.HasOne(d => d.Module)
                    .WithMany(p => p.Permissions)
                    .HasForeignKey(d => d.ModuleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("module_permission");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Permissions)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Role_permission");
            });

            modelBuilder.Entity<Profile>(entity =>
            {
                entity.Property(e => e.Address).IsUnicode(false);

                entity.Property(e => e.City).IsUnicode(false);

                entity.Property(e => e.FirstName).IsUnicode(false);

                entity.Property(e => e.LastName).IsUnicode(false);

                entity.Property(e => e.PostalCode).IsUnicode(false);

                entity.Property(e => e.Profilecol).IsUnicode(false);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Profiles)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Company_Profile");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Profiles)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Country_profile");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.RoleName).IsUnicode(false);
            });

            modelBuilder.Entity<StepCount>(entity =>
            {
                entity.HasOne(d => d.Connection)
                    .WithMany(p => p.StepCounts)
                    .HasForeignKey(d => d.ConnectionId)
                    .HasConstraintName("device-assign_step_count");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.StepCounts)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("user_stepcount");
            });

            modelBuilder.Entity<Symptom>(entity =>
            {
                entity.Property(e => e.Symptom1).IsUnicode(false);

                entity.HasOne(d => d.Measuring)
                    .WithMany(p => p.Symptoms)
                    .HasForeignKey(d => d.MeasuringId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_symptom_Measurings");
            });

            modelBuilder.Entity<SymptomIllness>(entity =>
            {
                entity.HasOne(d => d.Illness)
                    .WithMany(p => p.SymptomIllnesses)
                    .HasForeignKey(d => d.IllnessId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Illness_SymptomIllness");

                entity.HasOne(d => d.Symptom)
                    .WithMany(p => p.SymptomIllnesses)
                    .HasForeignKey(d => d.SymptomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("symptom_SymptomIllness");
            });

            modelBuilder.Entity<Timestamp>(entity =>
            {
                entity.Property(e => e.IpAddress).IsUnicode(false);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Timestamps)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Company_timestamps");

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.Timestamps)
                    .HasForeignKey(d => d.ProfileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Profile_timestamps");
            });

            modelBuilder.Entity<TriggerWarning>(entity =>
            {
                entity.Property(e => e.Status).IsUnicode(false);

                entity.HasOne(d => d.BloodPressure)
                    .WithMany(p => p.TriggerWarnings)
                    .HasForeignKey(d => d.BloodPressureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_trigger-warning_BloodPressure");

                entity.HasOne(d => d.HeartRec)
                    .WithMany(p => p.TriggerWarnings)
                    .HasForeignKey(d => d.HeartRecId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("heart_rate_trigger-warinng");

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.TriggerWarnings)
                    .HasForeignKey(d => d.ProfileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("user_trigger-warning");

                entity.HasOne(d => d.Symptom)
                    .WithMany(p => p.TriggerWarnings)
                    .HasForeignKey(d => d.SymptomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_trigger-warning_symptom");

                entity.HasOne(d => d.Temp)
                    .WithMany(p => p.TriggerWarnings)
                    .HasForeignKey(d => d.TempId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("body_temperature_trigger-warning");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.Mobiledevicetoken).IsUnicode(false);

                entity.Property(e => e.Password).IsUnicode(false);

                entity.Property(e => e.UserDynamickey).IsUnicode(false);

                entity.Property(e => e.UserSecret).IsUnicode(false);

                entity.Property(e => e.Username).IsUnicode(false);

                entity.Property(e => e.Webapplicationtoken).IsUnicode(false);

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.ProfileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("profile_user");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("role_user");
            });

            modelBuilder.Entity<UserConfiguration>(entity =>
            {
                entity.Property(e => e.StringValue).IsUnicode(false);

                entity.HasOne(d => d.Configuration)
                    .WithMany(p => p.UserConfigurations)
                    .HasForeignKey(d => d.ConfigurationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Configuration_UserConfiguration");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserConfigurations)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("user_UserConfiguration");
            });

            modelBuilder.Entity<UserSequence>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserSequences)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("User_UserSequence");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
