using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioursPatterns.ChainOfResponsibility
{        public class InvoiceHandler : DocumentHandler
        {
            public override void Handle(string document)
            {
                if (document == "Invoice")
                {
                    Console.WriteLine("Processing Invoice...");
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
