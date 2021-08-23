using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartWatch.DbModels;

namespace SmartWatch.Areas.UserDataSequence.Models.ViewModels
{
    public class UserDataSequenceViewModel
    {
        public long UserSequenceId { get; set; }
        public int UserId { get; set; }
        public double ValuesInSeconds { get; set; }
        public bool IsSentBloodPressure { get; set; }
        public bool IsSentStepCount { get; set; }
        public bool IsSentBodyTemperature { get; set; }
        public bool IsSentHeartRate { get; set; }
        public DateTime DateTimeSet { get; set; }
        public DateTime DateTimeSend { get; set; }

        public string UserName { get; set; }
        public List<User> userList { get; set; } = new List<User>();
    }
}
