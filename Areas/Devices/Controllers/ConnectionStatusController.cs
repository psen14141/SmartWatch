using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartWatch.Areas.Devices.Models.ViewModels;
using SmartWatch.DbModels;

namespace SmartWatch.Areas.Devices.Controllers
{
    [Area("Devices")]
    public class ConnectionStatusController : Controller
    {
        public IActionResult Index()
        {
            List<ConnectionStatus> connectionStatuses = new List<ConnectionStatus>();
            using (SmartWatchContext db = new SmartWatchContext())
            {
                connectionStatuses = db.ConnectionStatuses.ToList();
            }
            return View(connectionStatuses);
        }

        public IActionResult AddorEdit(long Id)
        {
            ConnectionStatusViewModel connectionStatusViewModel = new ConnectionStatusViewModel();
            using (SmartWatchContext db = new SmartWatchContext())
            {
                if (Id != 0)
                {
                    DbModels.ConnectionStatus connectionStatus = db.ConnectionStatuses.Where(w => w.ConnectionstatusId == Id).First();
                    connectionStatusViewModel.ConnectionstatusId = connectionStatus.ConnectionstatusId;
                    connectionStatusViewModel.ConnectId = connectionStatus.ConnectId;
                    connectionStatusViewModel.Status = connectionStatus.Status;
                    connectionStatusViewModel.SyncPeriodStartTime = connectionStatus.SyncPeriodStartTime;
                    connectionStatusViewModel.SyncPeriodEndTime = connectionStatus.SyncPeriodEndTime;
                }
                
            }
            return View(connectionStatusViewModel);
        }

        public IActionResult SaveConnectionStatus(DbModels.ConnectionStatus connectionStatus)
        {
            using (SmartWatchContext db = new SmartWatchContext())
            {

                if (connectionStatus.ConnectionstatusId == 0)
                {
                    db.ConnectionStatuses.Add(connectionStatus);
                }

                else
                {
                    DbModels.ConnectionStatus connectionSave = db.ConnectionStatuses.Where(w => w.ConnectionstatusId == connectionStatus.ConnectionstatusId).First();
                    connectionSave.ConnectionstatusId = connectionStatus.ConnectionstatusId;
                    connectionSave.ConnectId = connectionStatus.ConnectId;
                    connectionSave.Status = connectionStatus.Status;
                    connectionSave.SyncPeriodStartTime = connectionStatus.SyncPeriodStartTime;
                    connectionSave.SyncPeriodEndTime = connectionStatus.SyncPeriodEndTime;
                }
                db.SaveChanges();
            }

            return Redirect("/Devices/ConnectionStatus/Index");
        }

        public IActionResult Delete(int Id)
        {
            using (SmartWatchContext db = new SmartWatchContext())
            {

                DbModels.ConnectionStatus connectionStatus = db.ConnectionStatuses.Where(w => w.ConnectionstatusId == Id).First();
                if (connectionStatus != null)
                {
                    db.ConnectionStatuses.Remove(connectionStatus);
                }
                db.SaveChanges();
            }

            return Redirect("/Devices/ConnectionStatus/Index");
        }
    }
}
