using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartWatch.Areas.Countries.Models.ViewModels;
using SmartWatch.DbModels;


namespace SmartWatch.Areas.Countries.Controllers
{
    [Area("Countries")]
    public class CountryController : Controller
    {
        public IActionResult Index()
        {
            //List<CountryViewModel> countryViewModels = new List<CountryViewModel>();
            List<Country> countries = new List<Country>();
            using (SmartWatchContext db = new SmartWatchContext())
            {
                countries = db.Countries.ToList();
                
            }
            countries = countries.Where(w => w.CountryIsDelete == false).ToList();
            return View(countries);

        }

        public IActionResult AddorEdit(long Id)
        {
            CountryViewModel countryViewModel = new CountryViewModel();

            using (SmartWatchContext db = new SmartWatchContext())
            {
                if (Id != 0)
                {
                    DbModels.Country country = db.Countries.Where(w => w.CountryCode == Id).First();
                    countryViewModel.CountryCode = country.CountryCode;
                    countryViewModel.Country1 = country.Country1;
                    countryViewModel.TimeDifferenceHour = country.TimeDifferenceHour;
                    countryViewModel.TimeDifferenceMinute = country.TimeDifferenceMinute;
                    
                }
            }
                return View(countryViewModel);
        }

        public IActionResult SaveCountry(DbModels.Country country)
        {
            using (SmartWatchContext db = new SmartWatchContext())
            {

                if (country.CountryCode == 0)
                {
                    db.Countries.Add(country);
                }

                else
                {
                    DbModels.Country dbcountrysave = db.Countries.Where(w => w.CountryCode == country.CountryCode).First();

                    dbcountrysave.CountryCode = country.CountryCode;
                    dbcountrysave.Country1 = country.Country1;
                    dbcountrysave.TimeDifferenceHour = country.TimeDifferenceHour;
                    dbcountrysave.TimeDifferenceMinute = country.TimeDifferenceMinute;
                }
                db.SaveChanges();
            }

            return Redirect("/Countries/Country/Index");
        }

        public IActionResult Delete(int Id)
        {
            using (SmartWatchContext db = new SmartWatchContext())
            {

                DbModels.Country countryDelete = db.Countries.Where(w => w.CountryCode == Id).First();
                if (countryDelete != null)
                {
                    countryDelete.CountryIsDelete = true;
                }
                db.SaveChanges();
            }

            return Redirect("/Countries/Country/Index");
        }
    }
}
