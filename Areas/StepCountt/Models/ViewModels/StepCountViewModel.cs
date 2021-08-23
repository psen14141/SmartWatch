using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartWatch.Areas.StepCountt.Models.ViewModels
{
    public class StepCountViewModel
    {
        public long StepCountId { get; set; }
        public int UserId { get; set; }
        public long? ConnectionId { get; set; }
        public long Steps { get; set; }
        public DateTime Timestamp { get; set; }
        public DateTime DeviceTime { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public int ProfileId { get; set; }
        public string selectedDate { get; set; }
        public string weeklyStepName { get; set; }
        public long weeklyStepCount { get; set; }
        public string monthlyStepName { get; set; }
        public long monthlyStepCount { get; set; }
        public DateTime todayDate { get; set; }
        public string datewithSuffix { get; set; }
        public string weekDates { get; set; }
        public List<StepCountViewModel> stepCounts { get; set; } = new List<StepCountViewModel>();
        public List<StepCountViewModel> WeeklyCount { get; set; } = new List<StepCountViewModel>();
        public List<StepCountViewModel> MonthlyCount { get; set; } = new List<StepCountViewModel>();
        public List<DbModels.User> users { get; set; } = new List<DbModels.User>();

    }
}