using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioursPatterns.Visitor
{
    public class ValidationVisitor : IVisitor
    {
        public void Visit(ElementA element) { Console.WriteLine("Validating ElementA..."); }
        public void Visit(ElementB element) { Console.WriteLine("Validating ElementB..."); }
    }
}
