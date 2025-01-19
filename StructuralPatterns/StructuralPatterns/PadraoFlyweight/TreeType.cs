using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.PadraoFlyweight
{
    public class TreeType
    {
        public string Name { get; }
        public string Color { get; }

        public TreeType(string name, string color)
        {
            Name = name;
            Color = color;
        }

        public void Display(double x, double y)
        {
            Console.WriteLine($"Exibindo árvore {Name} na cor {Color} na posição ({x}, {y})");
        }
    }
}
