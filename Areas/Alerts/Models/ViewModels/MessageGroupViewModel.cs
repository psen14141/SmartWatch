using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartWatch.Areas.Alerts.Models.ViewModels
{
    public class MessageGroupViewModel
    {
        public int GroupId { get; set; }
        public string Name { get; set; }
        public bool? GroupIsDelete { get; set; }
    }
}
