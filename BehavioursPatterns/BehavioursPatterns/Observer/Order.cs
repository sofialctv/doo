using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioursPatterns.Observer
{
    public class Order
    {
        private List<IObserver> _observers = new();
        public void Attach(IObserver observer) { _observers.Add(observer); }
        public void UpdateStatus(string status) { foreach (var observer in _observers) { observer.Update(status); } }
    }
}
