using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioursPatterns.Observer
{
    public class SmsNotifier : IObserver { public void Update(string status) { Console.WriteLine($"SMS: Your order is now {status}."); } }
}
