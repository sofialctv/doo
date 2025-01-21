using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioursPatterns.Strategy
{
    public interface IShippingStrategy { decimal Calculate(decimal weight); }

}
