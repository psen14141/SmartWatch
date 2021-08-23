using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartWatch.Areas.UserDataSequence.Models.ViewModels;
using SmartWatch.DbModels;

namespace SmartWatch.Areas.UserDataSequence.Controllers
{
    [Area("UserDataSequence")]
    public class UserDataSquenceController : Controller
    {
        public IActionResult Index()
        {
            List<UserDataSequenceViewModel> userDataSequenceViewModels = new List<UserDataSequenceViewModel>();
            List<UserSequence> userSequences = new List<UserSequence>();

            using (SmartWatchContext db = new SmartWatchContext())
            {
                var userDataSeq = db.UserSequences.Join
                  (db.Users,
                  user => user.UserId,
                  dataseq => dataseq.UserId,
                  (user, dataseq) => new { UserSequence = user, Users = dataseq }
                  );

                foreach (var item in userDataSeq)
                {

                    UserDataSequenceViewModel dataSequenceViewModel = new UserDataSequenceViewModel();
                    dataSequenceViewModel.UserSequenceId = item.UserSequence.UserSequenceId;
                    dataSequenceViewModel.UserId = item.Users.UserId;
                    dataSequenceViewModel.UserName = item.Users.Username;
                    dataSequenceViewModel.ValuesInSeconds = item.UserSequence.ValuesInSeconds;
                    dataSequenceViewModel.IsSentBloodPressure = item.UserSequence.IsSentBloodPressure;
                    dataSequenceViewModel.IsSentBodyTemperature = item.UserSequence.IsSentBodyTemperature;
                    dataSequenceViewModel.IsSentHeartRate = item.UserSequence.IsSentHeartRate;
                    dataSequenceViewModel.IsSentStepCount = item.UserSequence.IsSentStepCount;
                    dataSequenceViewModel.DateTimeSend = item.UserSequence.DateTimeSend;
                    dataSequenceViewModel.DateTimeSet = item.UserSequence.DateTimeSet;
                    userDataSequenceViewModels.Add(dataSequenceViewModel);


                }

                return View(userDataSequenceViewModels);
            }
        }

        public IActionResult AddorEdit(long Id)
        {
            UserDataSequenceViewModel dataSequenceViewModel = new UserDataSequenceViewModel();

            using (SmartWatchContext db = new SmartWatchContext())
            {
                if (Id != 0)
                {
                    UserSequence userSequence = db.UserSequences.Where(w => w.UserId == Id).First();
                    dataSequenceViewModel.UserSequenceId = userSequence.UserSequenceId;
                    dataSequenceViewModel.UserId = userSequence.UserId;
                    dataSequenceViewModel.ValuesInSeconds = userSequence.ValuesInSeconds;
                    dataSequenceViewModel.IsSentBloodPressure = userSequence.IsSentBloodPressure;
                    dataSequenceViewModel.IsSentBodyTemperature = userSequence.IsSentBodyTemperature;
                    dataSequenceViewModel.IsSentHeartRate = userSequence.IsSentHeartRate;
                    dataSequenceViewModel.IsSentStepCount = userSequence.IsSentStepCount;
                    dataSequenceViewModel.DateTimeSend = userSequence.DateTimeSend;
                    dataSequenceViewModel.DateTimeSet = userSequence.DateTimeSet;

                   
                    dataSequenceViewModel.userList = db.Users.ToList();//for dropdown

                }
                dataSequenceViewModel.DateTimeSet = DateTime.Now;
                dataSequenceViewModel.DateTimeSend = DateTime.Now;
                dataSequenceViewModel.userList = db.Users.ToList();
            }
            return View(dataSequenceViewModel);
        }

        public IActionResult SaveDataSeq(DbModels.UserSequence userSequence)
        {
            using (SmartWatchContext db = new SmartWatchContext())
            {

                if (userSequence.UserSequenceId == 0)
                {
                    db.UserSequences.Add(userSequence);
                }

                else
                {
                    
                    DbModels.UserSequence dbuserSequenceSave = db.UserSequences.Where(w => w.UserId == userSequence.UserId).First();
                    dbuserSequenceSave.UserSequenceId = userSequence.UserSequenceId;
                    dbuserSequenceSave.UserId = userSequence.UserId;
                    dbuserSequenceSave.IsSentBloodPressure = userSequence.IsSentBloodPressure;
                    dbuserSequenceSave.IsSentBodyTemperature = userSequence.IsSentBodyTemperature;
                    dbuserSequenceSave.IsSentHeartRate = userSequence.IsSentHeartRate;
                    dbuserSequenceSave.IsSentStepCount = userSequence.IsSentStepCount;
                    dbuserSequenceSave.ValuesInSeconds = userSequence.ValuesInSeconds;
                    dbuserSequenceSave.DateTimeSend = userSequence.DateTimeSend;
                    dbuserSequenceSave.DateTimeSet = userSequence.DateTimeSet;
                }
                db.SaveChanges();
            }

            return Redirect("/UserDataSequence/UserDataSquence/Index");
        }

        public IActionResult Delete(int Id)
        {
            using (SmartWatchContext db = new SmartWatchContext())
            {

                DbModels.UserSequence dbuserSequenceDelete = db.UserSequences.Where(w => w.UserId == Id).First();
                if (dbuserSequenceDelete != null)
                {
                    db.UserSequences.Remove(dbuserSequenceDelete);
                    db.SaveChanges();
                }
                
            }

            return Redirect("/Companies/Company/Index");
        }
    }
}
