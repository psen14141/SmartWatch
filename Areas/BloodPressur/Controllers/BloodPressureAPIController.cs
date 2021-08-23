using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SmartWatch.Areas.BloodPressur.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartWatch.DbModels;

namespace SmartWatch.Areas.BloodPressur
{
    [Area("BloodPressur")]
    [Route("api/BloodPressur/[controller]")]
    [ApiController]
    public class BloodPressureAPIController : ControllerBase
    {
        public int GetBloodPressure(BloodPresureAPIRequest req)
        {
            
            using (SmartWatchContext db = new SmartWatchContext()) 
            { 
                var dassgn = db.DeviceAssigns.Where(w => w.DeviceId == req.DeviceId).Join
                    (db.Devices,
                    devassgn => devassgn.DeviceId,
                    dvce => dvce.DeviceId,
                    (devassgn, dvce) => new { DeviceAssign = devassgn, Device = dvce }
            
                    ).LastOrDefault();
                if (dassgn != null)
                {
                    BloodPressure bloodPressure = new BloodPressure()
                    {
                        ConnectionId = null,
                        UserId = dassgn.DeviceAssign.UserId,
                        BloodPreesureLower = req.BloodPresureLower,
                        BloodPressureUpper = req.BloodPresureUpper,
                        DeviceTime = req.DiviceTime,
                        Checkedtime = DateTime.UtcNow,

                    };
                    db.BloodPressures.Add(bloodPressure);
                }
                db.SaveChanges();
            }
            //1. Identify the patient 
            //2. make model
            //3. store model

            return 0;
        }

    }
}
