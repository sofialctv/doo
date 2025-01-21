using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioursPatterns.State
{
    public class SoldState : IState { public void Handle(VendingMachine vendingMachine) { Console.WriteLine("Product dispensed."); vendingMachine.SetState(new NoCoinState()); } }
}
