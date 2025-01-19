using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.PadraoBridge
{
    public class RedColor : IColor
    {
        public void ApplyColor() => Console.WriteLine("Aplicando a cor vermelha.");
    }
}
