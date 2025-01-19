using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.PadraoDecorator
{
    public class SMSDecorator : BaseNotification
    {
        private INotification _notification;
        public SMSDecorator(INotification notification) => _notification = notification;
        public override void Send(string message)
        {
            _notification.Send(message);
            Console.WriteLine("Via SMS");
        }
    }
}
