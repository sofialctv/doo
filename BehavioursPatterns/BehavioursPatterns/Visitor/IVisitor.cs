using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioursPatterns.Visitor
{
    public interface IVisitor { void Visit(ElementA element); void Visit(ElementB element); }

}
