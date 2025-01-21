using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioursPatterns.Strategy
{
    public class EconomyShipping : IShippingStrategy { public decimal Calculate(decimal weight) => weight * 0.1m; }

}
