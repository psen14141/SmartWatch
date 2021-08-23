using Microsoft.AspNetCore.Mvc;
using SmartWatch.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartWatch.Areas.Symptomillnesses.Models.ViewModels;


namespace SmartWatch.Areas.Symptomillnesses.Controllers
{
    [Area("Symptomillnesses")]
    public class IllnessController : Controller
    {
        
        public IActionResult Index()
        {
            List<SmartWatch.DbModels.Illness> illness = new List<SmartWatch.DbModels.Illness>();
            using(SmartWatchContext db = new SmartWatchContext())
            {
                illness = db.Illnesses.ToList();
            }
            return View(illness);
        }

        public IActionResult AddorEditView(int Id)
        {
            IllnessViewModel illnessViewModel = new IllnessViewModel();
            using (SmartWatchContext db = new SmartWatchContext())
            {
                if (Id != 0)
                {
                    SmartWatch.DbModels.Illness illness = db.Illnesses.Where(w => w.IllNessId == Id).First();
                    illnessViewModel.IllNessId = illness.IllNessId;
                    illnessViewModel.IllNessName = illness.IllNessName;
                    illnessViewModel.IllnessDescription = illness.IllnessDescription;
                }
                else
                {
                }
                illnessViewModel.illnessList = db.Illnesses.ToList();
            }
            return View(illnessViewModel);
        }
        public IActionResult DetailView(int Id)
        {

            IllnessViewModel illnessViewModel = new IllnessViewModel();
            using (SmartWatchContext db = new SmartWatchContext())

            {

                SmartWatch.DbModels.Illness illness = db.Illnesses.Where(w => w.IllNessId == Id).First();
                illnessViewModel.IllNessName = illness.IllNessName;
                illnessViewModel.IllnessDescription = illness.IllnessDescription;


            }
            return View(illnessViewModel);
        }
        public ActionResult SaveChanges(Illness formill)
        {
            using (SmartWatchContext db = new SmartWatchContext())
            {
                if (formill.IllNessId == 0)
                {
                    db.Illnesses.Add(formill);
                }
                else
                {
                    Illness dbill = db.Illnesses
                        .Where(w => w.IllNessId == formill.IllNessId).FirstOrDefault();

                    dbill.IllNessId = formill.IllNessId;
                    dbill.IllNessName = formill.IllNessName;
                    dbill.IllnessDescription = formill.IllnessDescription;


                }
                db.SaveChanges();
            }
            return Redirect("/Symptomillnesses/Illness/Index");
        }
        public IActionResult Delete(int Id)
        {
            using (SmartWatchContext db = new SmartWatchContext())
            {
                Illness dbIll = db.Illnesses.Where(w => w.IllNessId == Id).First();

                db.Illnesses.Remove(dbIll);
                db.SaveChanges();
            }
            return Redirect("/Symptomillnesses/Illness/Index");
        }
    }
}
