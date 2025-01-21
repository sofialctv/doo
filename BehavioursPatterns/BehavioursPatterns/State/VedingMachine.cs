using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioursPatterns.State
{
    public class VendingMachine
    {
        private IState _state = new NoCoinState();
        public void SetState(IState state) { _state = state; }
        public void InsertCoin() { _state.Handle(this); }
        public void SelectProduct() { _state.Handle(this); }
        public void DispenseProduct() { _state.Handle(this); }
    }
}
