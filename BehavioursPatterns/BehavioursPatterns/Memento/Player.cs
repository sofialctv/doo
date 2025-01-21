using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioursPatterns.Memento
{
    public class Player
    {
        public int Position { get; set; }
        public int Health { get; set; }
        public PlayerMemento SaveState() => new PlayerMemento(Position, Health);
        public void RestoreState(PlayerMemento memento) { Position = memento.Position; Health = memento.Health; }
    }
}
