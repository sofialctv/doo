using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.PadraoDecorator
{
    public class BaseNotification : INotification
    {
        public virtual void Send(string message) => Console.WriteLine($"Enviando notificação: {message}");
    }
}
