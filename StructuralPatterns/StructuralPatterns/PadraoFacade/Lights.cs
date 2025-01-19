using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.PadraoFacade
{
    public class Lights
    {
        public void Dim() => Console.WriteLine("Luzes diminuídas.");
        public void On() => Console.WriteLine("Luzes acesas.");
    }
}
