using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartWatch.DbModels;
using SmartWatch.Areas.Symptomillnesses.Models.ViewModels;


namespace SmartWatch.Areas.Symptomillnesses.Models.ViewModels
{
    public class SymptomViewModel
    {
        public DbModels.Symptom Symptoms { get; set; }
        public long SymptomId { get; set; }
        public string Symptom1 { get; set; }
        public int MinWarning { get; set; }
        public int MaxWarning { get; set; }
        public DateTime Timestamp { get; set; }
        public int? MinWarningCritical { get; set; }
        public int? MaxWarningCritical { get; set; }
        public int MeasuringId { get; set; }
        public string MeasuringName { get; set; }
        public virtual Measuring Measuring { get; set; }
        public List<DbModels.Symptom> symptomList { get; set; } = new List<DbModels.Symptom>();
        public List<DbModels.Measuring> measuringList { get; set; } = new List<DbModels.Measuring>();

    }
}
