using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioursPatterns.Memento
{
    public class PlayerMemento
    {
        public int Position { get; }
        public int Health { get; }
        public PlayerMemento(int position, int health) { Position = position; Health = health; }
    }
}
