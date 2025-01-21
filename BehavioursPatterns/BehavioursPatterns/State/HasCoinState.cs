using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioursPatterns.State
{
    public class HasCoinState : IState { public void Handle(VendingMachine vendingMachine) { Console.WriteLine("Product selected."); vendingMachine.SetState(new SoldState()); } }

}
