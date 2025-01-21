using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioursPatterns.ChainOfResponsibility
{
    public class ReceiptHandler : DocumentHandler
    {
        public override void Handle(string document)
        {
            if (document == "Receipt")
            {
                Console.WriteLine("Processing Receipt...");
            }
            else if (_next != null)
            {
                _next.Handle(document);  
            }
            else
            {
                Console.WriteLine("Cannot process " + document);  
            }
        }
    }
}
