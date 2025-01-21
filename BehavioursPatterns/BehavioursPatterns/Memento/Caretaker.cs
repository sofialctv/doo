using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioursPatterns.Memento
{
    public class Caretaker
    {
        private Stack<PlayerMemento> _mementos = new();
        public void Save(PlayerMemento memento) { _mementos.Push(memento); }
        public void Restore(Player player) { if (_mementos.Any()) player.RestoreState(_mementos.Pop()); }
    }
}
