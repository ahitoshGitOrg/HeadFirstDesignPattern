using HeadFirstDesignPattern.ObserverPattern.ObserverDataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPattern.ObserverPattern
{
    internal class EventLogObserver : IObserver, IDisplayDevice
    {
        NotifyData receivedData;
        IPublisher publisherRef;
        public EventLogObserver(IPublisher pub)
        {
            publisherRef = pub;
            pub.RegisterObserver(this);
        }
        public void Display()
        {
            Console.WriteLine($"Reveived Type =  {receivedData.Type} on : {receivedData.NotificationDateTime} with Remarks = {receivedData.Remarks}");
        }

        public void Update(NotifyData data)
        {
            receivedData = data;
            Display();
        }
        public void Unregister()
        {
            publisherRef.UnregisterObserver(this);
        }
    }
}
