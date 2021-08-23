using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartWatch.Areas.Companies.Models.ViewModels;
using SmartWatch.DbModels;

namespace SmartWatch.Areas.Companies.Controllers
{
    [Area("Companies")]
    public class CompanyController : Controller
    {
        public IActionResult Index()
        {
            List<CompanyViewModel> companyViewModels = new List<CompanyViewModel>();
           
            List<Company> companies = new List<Company>();
            using (SmartWatchContext db = new SmartWatchContext())
            {
                var compnaycountry = db.Companies.Join
                  (db.Countries,
                  cmpny => cmpny.CompanyId,
                  cuntry => cuntry.CountryCode,
                 (cmpny, cuntry) => new { Companies = cmpny, Countries = cuntry }
                  );

                foreach (var item in compnaycountry)
                {
                    CompanyViewModel companyViewModel = new CompanyViewModel();
                    companyViewModel.CompanyId = item.Companies.CompanyId;
                    companyViewModel.Name = item.Companies.Name.Trim();
                    companyViewModel.RegNo = item.Companies.RegNo.Trim();
                    companyViewModel.Phone = item.Companies.Phone;
                    companyViewModel.Logo = item.Companies.Logo;
                    companyViewModel.CountryId = item.Companies.CountryId;
                    companyViewModel.Country1 = item.Countries.Country1;
                    companyViewModel.CompanyBranchColor = item.Companies.CompanyBranchColor;
                    companyViewModel.CompanyForColor = item.Companies.CompanyForColor;
                    companyViewModel.CompanyIsDelete = item.Countries.CountryIsDelete;
                    companyViewModels.Add(companyViewModel);
                  
                }
                
                companyViewModels = companyViewModels.Where(w => w.CompanyIsDelete == false).ToList();

                return View(companyViewModels);

            }
        }

        public IActionResult AddorEdit(long Id)
        {
            CompanyViewModel companyViewModel = new CompanyViewModel();

            using (SmartWatchContext db = new SmartWatchContext())
            {
                if (Id != 0)
                {
                    DbModels.Company company = db.Companies.Where(w => w.CompanyId == Id).First();
                    companyViewModel.CompanyId = company.CompanyId;
                    companyViewModel.Name = company.Name.Trim();
                    companyViewModel.RegNo = company.RegNo.Trim();
                    companyViewModel.Phone = company.Phone;
                    companyViewModel.Logo = company.Logo;
                    companyViewModel.CountryId = company.CountryId;
                    companyViewModel.CompanyBranchColor = company.CompanyBranchColor;
                    companyViewModel.CompanyForColor = company.CompanyForColor;

                    companyViewModel.countryList = db.Countries.ToList();//for dropdown
                   
                }
                companyViewModel.countryList = db.Countries.ToList();
            }
            return View(companyViewModel);
        }

        public IActionResult SaveCompany(DbModels.Company company)
        {
            using (SmartWatchContext db = new SmartWatchContext())
            {

                if (company.CompanyId == 0)
                {
                    db.Companies.Add(company);
                }

                else
                {
                    DbModels.Company dbcompanysave = db.Companies.Where(w => w.CompanyId == company.CompanyId).First();

                    dbcompanysave.CompanyId = company.CompanyId;
                    dbcompanysave.Name = company.Name.Trim();
                    dbcompanysave.RegNo = company.RegNo.Trim();
                    dbcompanysave.Phone = company.Phone;
                    dbcompanysave.Logo = company.Logo;
                    dbcompanysave.CountryId = company.CountryId;
                    dbcompanysave.CompanyBranchColor = company.CompanyBranchColor;
                    dbcompanysave.CompanyForColor = company.CompanyForColor;
                }
                db.SaveChanges();
            }

            return Redirect("/Companies/Company/Index");
        }

        public IActionResult Delete(int Id)
        {
            using (SmartWatchContext db = new SmartWatchContext())
            {

                DbModels.Company companyDelete = db.Companies.Where(w => w.CompanyId == Id).First();
                if (companyDelete != null)
                {
                    companyDelete.CompanyIsDelete = true;
                }
                db.SaveChanges();
            }

            return Redirect("/Companies/Company/Index");
        }
    }
}
