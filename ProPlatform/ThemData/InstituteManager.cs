using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using SmartWatch.DbModels;
using SmartWatch.ProPlatform.ThemData.Model.ViewModel;


namespace SmartWatch.ProPlatform.ThemData
{
    public class InstituteManager
    {
        public static InstituteInfo GetInstituteData(int instituteId)
        {
            InstituteInfo instituteInfo = new InstituteInfo();
            using (SmartWatchContext db = new SmartWatchContext())
            {
                /*var institute = db.Companies.Where(w => w.CompanyId == instituteId).FirstOrDefault();
                if(institute!= null)
                {
                    //instituteInfo.BackColor = institute.InstituteBranchColor;
                    //instituteInfo.FontColor = institute.InstituteForColor;
                    //instituteInfo.InstituteId = institute.InstituteId;
                    //instituteInfo.InstituteName = institute.InstituteName;
                    //instituteInfo.LogoPath = institute.InstituteLogo;

                }*/
            }
            return instituteInfo;
        }
    }
}
