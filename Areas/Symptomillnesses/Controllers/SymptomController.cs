using Microsoft.AspNetCore.Mvc;
using SmartWatch.Areas.Symptomillnesses.Models.ViewModels;
using SmartWatch.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartWatch.Areas.Symptomillnesses.Controllers
{
    [Area("Symptomillnesses")]
    public class SymptomController : Controller
    {
        public IActionResult Index()
        {
            List<SymptomViewModel> symptomViewModels = new List<SymptomViewModel>();
            using (SmartWatchContext db = new SmartWatchContext())
            {
                var illnesssymptoms = db.Symptoms.Join(
                    db.Measurings,
                        symptom => symptom.MeasuringId,
                        measuring => measuring.MeasuringId,

                        (symptom, measuring) => new { Symptom = symptom, Measuring = measuring }
                    );

                foreach (var item in illnesssymptoms)
                {
                    SymptomViewModel symptomViewModel = new SymptomViewModel();
                    symptomViewModel.SymptomId = item.Symptom.SymptomId;
                    symptomViewModel.Symptom1 = item.Symptom.Symptom1;
                    symptomViewModel.MinWarning = item.Symptom.MinWarning;
                    symptomViewModel.MaxWarning = item.Symptom.MaxWarning;
                    symptomViewModel.Timestamp = item.Symptom.Timestamp;
                    symptomViewModel.MinWarningCritical = item.Symptom.MinWarningCritical;
                    symptomViewModel.MaxWarningCritical = item.Symptom.MaxWarningCritical;
                    symptomViewModel.MeasuringId = item.Symptom.MeasuringId;

                    symptomViewModels.Add(symptomViewModel);

                }
            }
            symptomViewModels = symptomViewModels.ToList();
            return View(symptomViewModels);
        }

        public IActionResult AddorEditView(int Id = 0)
        {
            SymptomViewModel symtomViewModel = new SymptomViewModel();
            using (SmartWatchContext db = new SmartWatchContext())
            {
                if (Id != 0)
                {
                    Symptom symptom = db.Symptoms.Where(w => w.SymptomId == Id).First();

                    symtomViewModel.SymptomId = symptom.SymptomId;
                    symtomViewModel.Symptom1 = symptom.Symptom1;
                    symtomViewModel.MinWarning = symptom.MinWarning;
                    symtomViewModel.MaxWarning = symptom.MaxWarning;
                    symtomViewModel.Timestamp = symptom.Timestamp;
                    symtomViewModel.MeasuringId = symptom.MeasuringId;
                    symtomViewModel.MinWarningCritical = symptom.MinWarningCritical;
                    symtomViewModel.MaxWarningCritical = symptom.MaxWarningCritical;

                }
                else
                {
                    symtomViewModel.Timestamp = DateTime.Now;
                    
                }
                symtomViewModel.symptomList = db.Symptoms.ToList();
                symtomViewModel.measuringList = db.Measurings.ToList();
            }
            return View(symtomViewModel);
        }

        public ActionResult SaveChanges(Symptom formsymp)
        {
            using (SmartWatchContext db = new SmartWatchContext())
            {
                if (formsymp.SymptomId == 0)
                {
                    db.Symptoms.Add(formsymp);
                }
                else
                {
                    Symptom dbSym = db.Symptoms
                        .Where(w => w.SymptomId == formsymp.SymptomId).FirstOrDefault();

                    dbSym.SymptomId = formsymp.SymptomId;
                    dbSym.Symptom1 = formsymp.Symptom1;
                    dbSym.MinWarning = formsymp.MinWarning;
                    dbSym.MaxWarning = formsymp.MaxWarning;
                    dbSym.Timestamp = formsymp.Timestamp;
                    dbSym.MeasuringId = formsymp.MeasuringId;
                    dbSym.MinWarningCritical = formsymp.MinWarningCritical;
                    dbSym.MaxWarningCritical = formsymp.MaxWarningCritical;


                }
                db.SaveChanges();
            }
            return Redirect("/Symptomillnesses/Symptom/Index");
        }

        public IActionResult DetailView(int Id)
        {
            SymptomViewModel symptomViewModel = new SymptomViewModel();
            using (SmartWatchContext db = new SmartWatchContext())
            {
                symptomViewModel.Symptoms = db.Symptoms.Where(w => w.MeasuringId == Id).FirstOrDefault();

                symptomViewModel.measuringList = db.Symptoms.Where(w => w.SymptomId == Id).Join(db.Measurings,
                            symptom => symptom.MeasuringId,
                            measuring => measuring.MeasuringId,
                            (symptom, measuring) => new { Symptom = symptom, Measuring = measuring })
                        .Select(s => s.Measuring).ToList();
            }
            return View(symptomViewModel);
        }


        public IActionResult Delete(int Id)
        {
            using (SmartWatchContext db = new SmartWatchContext())
            {
                Symptom dbSym = db.Symptoms.Where(w => w.SymptomId == Id).First();

                db.Symptoms.Remove(dbSym);
                db.SaveChanges();
            }
            return Redirect("/Symptomillnesses/Symptom/Index");
        }

    }
}
