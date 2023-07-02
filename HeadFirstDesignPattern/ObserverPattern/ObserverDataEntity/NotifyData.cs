using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPattern.ObserverPattern.ObserverDataEntity
{
    public class NotifyData
    {
        public string Type { get; set; }
        public DateTime NotificationDateTime { get; set; } = DateTime.Now;
        public string Remarks { get; set; }
    }
}
