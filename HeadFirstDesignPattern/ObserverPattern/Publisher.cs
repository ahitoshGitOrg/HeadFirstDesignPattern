using HeadFirstDesignPattern.ObserverPattern.ObserverDataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPattern.ObserverPattern
{
    internal class Publisher : IPublisher
    {
        List<IObserver> observerList;
        NotifyData data;
        public Publisher()
        {
            observerList = new List<IObserver>();
        }
        public void NotifyObserver()
        {
            observerList.ForEach(item=>item.Update(data));
        }

        public void RegisterObserver(IObserver observer)
        {
            observerList.Add(observer);
        }

        public void UnregisterObserver(IObserver observer)
        {
            observerList.Remove(observer);
        }

        // Webhook that will be called as soon as there is a change in Data
        public void MeasurementChanged()
        {
            NotifyObserver();
        }

        // Manually set new data to give the impression of data change
        public void SetNotificationData(string type,string remarks)
        {
            data = new NotifyData { Type= type, Remarks= remarks };
            MeasurementChanged();
        }
    }
}
