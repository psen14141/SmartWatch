using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartWatch.DbModels;


namespace SmartWatch.Areas.Countries.Models.ViewModels
{
    public class CountryViewModel
    {

        public int CountryCode { get; set; }
        public string Country1 { get; set; }
        public int TimeDifferenceHour { get; set; }
        public int TimeDifferenceMinute { get; set; }
        public bool CountryIsDelete { get; set; }

    }
}
