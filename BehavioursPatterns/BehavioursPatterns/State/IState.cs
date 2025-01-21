using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioursPatterns.State
{
    public interface IState { void Handle(VendingMachine vendingMachine); }

}
