using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using SmartWatch.DbModels;
using SmartWatch.ProPlatform.Security;
using SmartWatch.ProPlatform.Users;

namespace SmartWatch.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Index()
        {
            //long userId = Convert.ToInt32(HttpContext.Session.GetString(SessionKeys.UserId));
            //long instituteId = Convert.ToInt32(HttpContext.Session.GetString(SessionKeys.OrgId));

            UserInformation userInformation = new UserInformation();
            userInformation.UserEnumType = UserTypesEunum.Administrator;
            //userInformation.UserId = userId;
            //userInformation.InstituteId = instituteId;

            //get user type
            /*using (LMSContext db = new LMSContext())
            {
                var userData = db.User.Where(w => w.UserId == userId).Join(
                    db.InstuteUserType,
                    user => user.InstituteUserTypeId,
                    instituteUserType => instituteUserType.InstituteUserTypeId,
                    (user, instituteUserType) => new { User = user, InstituteUserType = instituteUserType }
                )
                .Join(db.UserType,
                userInfor=> userInfor.InstituteUserType.UserTypeId,
                userType => userType.UserTypeId,
                (userInfor, userType)=> new { User = userInfor.User, InstituteUserType = userInfor.InstituteUserType , UserType = userType }
                ).FirstOrDefault() ; 

                if(userData != null)
                {
                    string userTypeName = userData.UserType.UserTypeName.ToLower();
                    if (UserTypesEunum.Student.ToString("g").ToLower() == userTypeName)
                    {
                        userInformation.UserEnumType = UserTypesEunum.Student;
                        
                    }
                    else if (UserTypesEunum.Administrator.ToString("g").ToLower() == userTypeName)
                    {
                        userInformation.UserEnumType = UserTypesEunum.Administrator;
                    }
                    else if (UserTypesEunum.Teachers.ToString("g").ToLower() == userTypeName)
                    {
                        userInformation.UserEnumType = UserTypesEunum.Teachers;
                    }
                }
            }*/

            return View(userInformation);
        }


    }

    public class UserInformation{
        public long UserId;
        public long UserType;
        public long InstituteId;
        public UserTypesEunum UserEnumType = UserTypesEunum.Other;

    }

  

}
