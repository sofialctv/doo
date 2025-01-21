using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioursPatterns.Visitor
{
    public class ElementA
    {
        public void Accept(IVisitor visitor) { visitor.Visit(this); }
    }
}
