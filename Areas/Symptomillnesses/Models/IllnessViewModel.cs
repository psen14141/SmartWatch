using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartWatch.DbModels;


namespace SmartWatch.Areas.Symptomillnesses.Models.ViewModels
{
    public class IllnessViewModel
    {
        public DbModels.Illness illness { get; set; }
        public int IllNessId { get; set; }
        public string IllNessName { get; set; }
        public string IllnessDescription { get; set; }

        public List<Illness> illnessList { get; set; } = new List<Illness>();

    }
}
