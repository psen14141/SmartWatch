using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartWatch.DbModels;


namespace SmartWatch.Areas.Companies.Models.ViewModels
{
    public class CompanyViewModel
    {
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public string RegNo { get; set; }
        public string Phone { get; set; }
        public string Logo { get; set; }
        public int CountryId { get; set; }
        public string CompanyBranchColor { get; set; }
        public string CompanyForColor { get; set; }
        public bool CompanyIsDelete { get; set; }

        public List<Country> countryList { get; set; } = new List<Country>();

        public string Country1 { get; set; }
    }
}
