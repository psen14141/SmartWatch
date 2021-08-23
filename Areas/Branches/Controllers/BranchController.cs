using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartWatch.DbModels;
using SmartWatch.Areas.Branches.Models.ViewModels;

namespace SmartWatch.Areas.Branches.Controllers
{

    [Area("Branches")]
    public class BranchController : Controller
    {
        public IActionResult Index()
        {
            List<BranchViewModel> branchViewModels = new List<BranchViewModel>();

            using (SmartWatchContext db = new SmartWatchContext())
            {

                var compnaybranch = db.Branches.Join
                    (db.Companies,
                    branchess => branchess.CompanyId,
                    cmpnaies => cmpnaies.CompanyId,
                    (Branchess, cmpanies) => new { Branch = Branchess, Company = cmpanies }
                    );

                var countrybrach = compnaybranch.Join
                    (db.Countries,
                    compnaybranchs => compnaybranchs.Branch.CompanyId,
                    countrs => countrs.CountryCode,
                    (compnaybranchs, countrs) => new { Branch = compnaybranchs, Country = countrs }
                    );

                foreach (var item in countrybrach)
                {
                    BranchViewModel branchViewModel = new BranchViewModel();
                    branchViewModel.BranchCode = item.Branch.Branch.BranchCode;
                    branchViewModel.BranchName = item.Branch.Branch.BranchName.Trim();
                    branchViewModel.CompanyId = item.Branch.Branch.CompanyId;
                    branchViewModel.CountryId = item.Branch.Branch.CountryId;
                    branchViewModel.Location = item.Branch.Branch.Location.Trim();
                    branchViewModel.Address = item.Branch.Branch.Address.Trim();
                    branchViewModel.Phone = item.Branch.Branch.Phone;
                    branchViewModel.BranchId = item.Branch.Branch.BranchId;
                    branchViewModel.Country1 = item.Country.Country1;
                    branchViewModel.Name = item.Branch.Company.Name.Trim();
                    branchViewModel.BranchIsDelete = item.Branch.Branch.BranchIsDelete;
                    branchViewModels.Add(branchViewModel);
                }

                branchViewModels = branchViewModels.Where(w => w.BranchIsDelete == false).ToList();

                return View(branchViewModels);
            }
        }


        public IActionResult AddOrEditBranch(int Id)
        {
            BranchViewModel branchViewModels = new BranchViewModel();
            using (SmartWatchContext db = new SmartWatchContext())
            {
                if (Id != 0)
                {
                    DbModels.Branch branch = db.Branches.Where(w => w.BranchId == Id).First();
                    branchViewModels.BranchId = branch.BranchId;
                    branchViewModels.BranchName = branch.BranchName.Trim();
                    branchViewModels.Address = branch.Address.Trim();
                    branchViewModels.Location = branch.Location.Trim();
                    branchViewModels.BranchCode = branch.BranchCode;
                    branchViewModels.Phone = branch.Phone;
                    branchViewModels.CountryId = branch.CountryId;
                    branchViewModels.CompanyId = branch.CompanyId;
                    branchViewModels.companies = db.Companies.ToList();
                    branchViewModels.countries = db.Countries.ToList();
           
                }
                else
                {

                    branchViewModels.companies = db.Companies.ToList();//for dropdown
                    branchViewModels.countries = db.Countries.ToList();
                }
            }
                    return View(branchViewModels);

        }

        public  IActionResult SaveBranch(DbModels.Branch formbranch)
        {
            using (SmartWatchContext db = new SmartWatchContext())
            {

                if (formbranch.BranchId == 0)
                {
                    db.Branches.Add(formbranch);
                }

                else
                {
                    DbModels.Branch dbbranchsave = db.Branches.Where(w => w.BranchId == formbranch.BranchId).First();
                    dbbranchsave.BranchId = formbranch.BranchId;
                    dbbranchsave.BranchCode = formbranch.BranchCode;
                    dbbranchsave.BranchName = formbranch.BranchName.Trim();
                    dbbranchsave.CountryId = formbranch.CountryId;
                    dbbranchsave.CompanyId = formbranch.CompanyId;
                    dbbranchsave.Address = formbranch.Address.Trim();
                    dbbranchsave.Location = formbranch.Location.Trim();
                    dbbranchsave.Phone = formbranch.Phone;
                   
                }
                db.SaveChanges();
            }
            return Redirect("/Branches/Branch/Index");
        }
        public IActionResult Delete(int Id)
        {
            using (SmartWatchContext db = new SmartWatchContext())
            {

                DbModels.Branch branchdelete = db.Branches.Where(w => w.BranchId == Id).FirstOrDefault();
                if (branchdelete != null)
                {
                    branchdelete.BranchIsDelete = true;

                }
                db.SaveChanges();

            }

            return Redirect("/Branches/Branch/Index");
        }

    }
}
