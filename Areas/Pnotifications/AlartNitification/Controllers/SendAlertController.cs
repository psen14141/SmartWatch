using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartWatch.Areas.Pnotifications.AlartNitification.Controllers
{
    public class SendAlertController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
