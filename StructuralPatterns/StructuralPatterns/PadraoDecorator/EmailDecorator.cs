using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.PadraoDecorator
{
    public class EmailDecorator : BaseNotification
    {
        private INotification _notification;
        public EmailDecorator(INotification notification) => _notification = notification;
        public override void Send(string message)
        {
            _notification.Send(message);
            Console.WriteLine("Via Email");
        }
    }
}
