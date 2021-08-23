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
    public class DeviceController : Controller
    {
        
        public IActionResult Index()
        {
            List<Device> devices = new List<Device>();
            using (SmartWatchContext db = new SmartWatchContext())
            {
                devices = db.Devices.ToList();

            }
            devices = devices.Where(w => w.DeviceIsDelete == false).ToList();
            return View(devices);
        }

        public IActionResult AddorEdit(long Id)
        {
            DeviceViewModel deviceViewModel = new DeviceViewModel();
            using (SmartWatchContext db = new SmartWatchContext())
            {
                if(Id != 0)
                {
                    DbModels.Device device = db.Devices.Where(w => w.DeviceId == Id).First();
                    deviceViewModel.DeviceId = device.DeviceId;
                    deviceViewModel.Type = device.Type;
                    deviceViewModel.DeviceCode = device.DeviceCode.Trim();
                }
                deviceViewModel.RegDate = DateTime.Now;
            }
                return View(deviceViewModel);
        }

        public IActionResult SaveDevice(DbModels.Device device)
        {
            using (SmartWatchContext db = new SmartWatchContext())
            {

                if (device.DeviceId == 0)
                {
                    db.Devices.Add(device);
                }

                else
                {
                    DbModels.Device dbdevicesave = db.Devices.Where(w => w.DeviceId == device.DeviceId).First();

                    dbdevicesave.DeviceId = device.DeviceId;
                    dbdevicesave.Type = device.Type;
                    dbdevicesave.DeviceCode = device.DeviceCode.Trim();
                    dbdevicesave.RegDate = device.RegDate;
                }
                db.SaveChanges();
            }

            return Redirect("/Devices/Device/Index");
        }

        public IActionResult Delete(int Id)
        {
            using (SmartWatchContext db = new SmartWatchContext())
            {

                DbModels.Device deviceDelete = db.Devices.Where(w => w.DeviceId == Id).First();
                if (deviceDelete != null)
                {
                    deviceDelete.DeviceIsDelete = true;
                }
                db.SaveChanges();
            }

            return Redirect("/Devices/Device/Index");
        }

        public IActionResult DeviceAssigns(int Id)
        {
            
            List<DeviceAssignViewModel> deviceAssignViewModels = new List<DeviceAssignViewModel>();
            using (SmartWatchContext db = new SmartWatchContext())
            {
                var dassgn = db.DeviceAssigns.Where(w => w.DeviceId == Id && w.DeviceAssignIsDelete == false).Join
                    (db.Devices,
                    devassgn => devassgn.DeviceId,
                    dvce => dvce.DeviceId,
                    (devassgn, dvce) => new { DeviceAssign = devassgn, Device = dvce }

                    );

                var usernamedevice = db.Users.Join
                    (dassgn,
                    usename => usename.UserId,
                    deviceuser => deviceuser.DeviceAssign.UserId,
                    (usename, deviceuser) => new { User = usename, DeviceAssign = deviceuser }
                    );

                foreach (var Item in usernamedevice)
                {
                    DeviceAssignViewModel deviceAssignViewModel = new DeviceAssignViewModel();
                    deviceAssignViewModel.ConnectNo = Item.DeviceAssign.DeviceAssign.ConnectNo;
                    deviceAssignViewModel.DeviceId = Item.DeviceAssign.DeviceAssign.DeviceId;
                    deviceAssignViewModel.AssignDateStart = Item.DeviceAssign.DeviceAssign.AssignDateStart;
                    deviceAssignViewModel.AssignDateEnd = Item.DeviceAssign.DeviceAssign.AssignDateEnd;
                    deviceAssignViewModel.UserId = Item.DeviceAssign.DeviceAssign.UserId;
                    deviceAssignViewModel.Username = Item.DeviceAssign.DeviceAssign.User.Username.Trim();
                    deviceAssignViewModels.Add(deviceAssignViewModel);
                    
                }
                ViewBag.deviceids = Id;
            }
            return View(deviceAssignViewModels);
        }

        public IActionResult DeviceAssignAdd(long Id, int connId)
        {
            DeviceAssignViewModel deviceAssignViewModel = new DeviceAssignViewModel();
            using (SmartWatchContext db = new SmartWatchContext())
            {
                if (Id != 0)
                {

                    DbModels.DeviceAssign deviceAssign = db.DeviceAssigns.Where(w => w.ConnectNo == Id).First();
                    deviceAssignViewModel.ConnectNo = deviceAssign.ConnectNo;
                    deviceAssignViewModel.DeviceId = deviceAssign.DeviceId;
                    deviceAssignViewModel.UserId = deviceAssign.UserId;
                    deviceAssignViewModel.AssignDateStart = deviceAssign.AssignDateStart;
                    deviceAssignViewModel.AssignDateEnd = deviceAssign.AssignDateEnd;
                    deviceAssignViewModel.users = db.Users.ToList();
                    deviceAssignViewModel.devicestype = db.Devices.ToList();
                }
                else
                {
                    deviceAssignViewModel.AssignDateStart = DateTime.Now;
                    deviceAssignViewModel.AssignDateEnd = DateTime.Now;
                    deviceAssignViewModel.users = db.Users.ToList();
                    deviceAssignViewModel.DeviceId = connId;
                }
           
            }
            return View(deviceAssignViewModel);

        }
        public IActionResult SaveDeviceAssign(DbModels.DeviceAssign deviceAssign)
        {
            using (SmartWatchContext db = new SmartWatchContext())
            {

                if (deviceAssign.ConnectNo == 0)
                {
                    db.DeviceAssigns.Add(deviceAssign);
                }

                else
                {
                    DbModels.DeviceAssign dbdeviceassignsave = db.DeviceAssigns.Where(w => w.ConnectNo == deviceAssign.ConnectNo).First();

                    dbdeviceassignsave.ConnectNo = deviceAssign.ConnectNo;
                    dbdeviceassignsave.DeviceId = deviceAssign.DeviceId;
                    dbdeviceassignsave.UserId = deviceAssign.UserId;
                    dbdeviceassignsave.AssignDateStart = deviceAssign.AssignDateStart;
                    dbdeviceassignsave.AssignDateEnd = deviceAssign.AssignDateEnd;
                    
                }
                db.SaveChanges();
            }

            return Redirect("/Devices/Device/DeviceAssigns");
        }

        public IActionResult DeviceAssignDelete(long Id)
        {
            using (SmartWatchContext db = new SmartWatchContext())
            {

                DbModels.DeviceAssign assigndevicedelete = db.DeviceAssigns.Where(w => w.ConnectNo == Id).FirstOrDefault();

                if (assigndevicedelete != null)
                {
                    assigndevicedelete.DeviceAssignIsDelete = true;

                }
                db.SaveChanges();

            }
            return Redirect("/Devices/Device/DeviceAssigns");


        }

        public IActionResult DeviceStatus(long Id)
        {
            List<ConnectionStatus> connectionStatuses = new List<ConnectionStatus>();
            using (SmartWatchContext db = new SmartWatchContext())
            {
                connectionStatuses = db.ConnectionStatuses.Where(w => w.ConnectId == Id).ToList();
            }
            ViewBag.connId = Id;
            return View(connectionStatuses);
            //    List<ConnectionStatusViewModel> connectionStatusViewModels = new List<ConnectionStatusViewModel>();
            //    using (SmartWatchContext db = new SmartWatchContext())
            //    {


            //        var usernamedevice = db.ConnectionStatuses.Where(w => w.ConnectId == Id).Join
            //            (dassgn,
            //            conect => conect.ConnectId,
            //            dasgn => dasgn.DeviceAssign.ConnectNo,
            //            (conect, dasgn) => new { ConnectionStatus = conect, DeviceAssign = dasgn }
            //            );

            //        foreach (var Item in usernamedevice)
            //        {

            //            ConnectionStatusViewModel connectionStatusViewModel = new ConnectionStatusViewModel();

            //            connectionStatusViewModel.ConnectId = Item.ConnectionStatus.ConnectId;
            //            connectionStatusViewModel.Status = Item.ConnectionStatus.Status;
            //            connectionStatusViewModel.SyncPeriodStartTime = Item.ConnectionStatus.SyncPeriodStartTime;
            //            connectionStatusViewModel.SyncPeriodEndTime = Item.ConnectionStatus.SyncPeriodEndTime;

            //            connectionStatusViewModels.Add(connectionStatusViewModel);

            //        }
            //        ViewBag.connId = Id;
            //    }
            //    return View(connectionStatusViewModels);
            }

            public IActionResult DeviceStatusChanges(long Id, long connId)
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
                else
                {
                    connectionStatusViewModel.ConnectId = connId;
                    connectionStatusViewModel.SyncPeriodStartTime = DateTime.Now;
                    connectionStatusViewModel.SyncPeriodEndTime = DateTime.Now;
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

            return Redirect("/Devices/Device/DeviceAssigns");
        }

        public IActionResult DeviceConnectionDelete(int Id)
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
