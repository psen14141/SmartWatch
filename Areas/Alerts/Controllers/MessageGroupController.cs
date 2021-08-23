using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartWatch.Areas.Alerts.Models.ViewModels;
using SmartWatch.DbModels;

namespace SmartWatch.Areas.Alerts.Controllers
{
    [Area("Alerts")]
    public class MessageGroupController : Controller
    {
        public IActionResult Index()
        {
            List<MessageGroup> messageGroups = new List<MessageGroup>();
            using (SmartWatchContext db = new SmartWatchContext())
            {
                messageGroups = db.MessageGroups.ToList();

            }
            messageGroups = messageGroups.Where(w => w.GroupIsDelete == false).ToList();
            return View(messageGroups);
        }

        public IActionResult AddorEdit(long Id)
        {
            MessageGroupViewModel messageGroupViewModel = new MessageGroupViewModel();
            using (SmartWatchContext db = new SmartWatchContext())
            {
                if (Id != 0)
                {
                    DbModels.MessageGroup messageGroup = db.MessageGroups.Where(w => w.GroupId == Id).First();
                    messageGroupViewModel.GroupId = messageGroup.GroupId;
                    messageGroupViewModel.Name = messageGroup.Name;
                }
                
            }
            return View(messageGroupViewModel);
        }

        public IActionResult SaveMessageGroup(DbModels.MessageGroup messageGroup)
        {
            using (SmartWatchContext db = new SmartWatchContext())
            {

                if (messageGroup.GroupId == 0)
                {
                    db.MessageGroups.Add(messageGroup);
                }

                else
                {
                    DbModels.MessageGroup messageGroupSave = db.MessageGroups.Where(w => w.GroupId == messageGroup.GroupId).First();
                    messageGroupSave.GroupId = messageGroup.GroupId;
                    messageGroupSave.Name = messageGroup.Name;
                }
                db.SaveChanges();
            }

            return Redirect("/Alerts/MessageGroup/Index");
        }

        public IActionResult Delete(int Id)
        {
            using (SmartWatchContext db = new SmartWatchContext())
            {

                DbModels.MessageGroup messageGroupDelete = db.MessageGroups.Where(w => w.GroupId == Id).First();
                if (messageGroupDelete != null)
                {
                    messageGroupDelete.GroupIsDelete = true;
                }
                db.SaveChanges();
            }

            return Redirect("/Alerts/MessageGroup/Index");
        }
    }
}
