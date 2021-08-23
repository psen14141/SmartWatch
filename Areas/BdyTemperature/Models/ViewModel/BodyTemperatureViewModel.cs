using System;
using System.Collections.Generic;
using System.Linq;
using SmartWatch.DbModels;
using System.Threading.Tasks;

namespace SmartWatch.Areas.BdyTemperature.Models.ViewModel
{
    public class BodyTemperatureViewModel
    {
        public long BodyTemperatureId { get; set; }
        public int userid { get; set; }
        public long? ConnectId { get; set; }
        public double Temperature { get; set; }
        public DateTime CheckedTimestamp { get; set; }
        public bool BodyTemperatureIsDelete { get; set; }
        public DateTime DeviceTime { get; set; }
        public DateTime fromdate { get; set; }
        public DateTime todate { get; set; }
        public List<BodyTemperature> bodyTemperatures { get; set; } = new List<BodyTemperature>();
        public List<User> users { get; set; } = new List<User>();


    }
}
