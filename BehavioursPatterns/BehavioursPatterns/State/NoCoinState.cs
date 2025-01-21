using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioursPatterns.State
{
    public class NoCoinState : IState { public void Handle(VendingMachine vendingMachine) { Console.WriteLine("Coin inserted."); vendingMachine.SetState(new HasCoinState()); } }

}
