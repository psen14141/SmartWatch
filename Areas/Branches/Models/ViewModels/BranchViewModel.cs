using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartWatch.DbModels;

namespace SmartWatch.Areas.Branches.Models.ViewModels
{
    public class BranchViewModel
    {

        public int BranchId { get; set; }
        public int CompanyId { get; set; }
        public int CountryId { get; set; }
        public int BranchCode { get; set; }
        public string Location { get; set; }
        public string BranchName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public bool BranchIsDelete { get; set; }

        public List<Company> companies { get; set; } = new List<Company>();
        public string Name { get; set; }

      
        public List<Country> countries { get; set; } = new List<Country>();

        public string Country1 { get; set; }
    } 
}
