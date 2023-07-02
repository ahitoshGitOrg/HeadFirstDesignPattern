using HeadFirstDesignPattern.ObserverPattern.ObserverDataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPattern.ObserverPattern
{
    internal interface IObserver
    {
        void Update(NotifyData data);
    }
}
