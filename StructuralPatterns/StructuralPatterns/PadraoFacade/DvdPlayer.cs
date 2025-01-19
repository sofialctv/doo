using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.PadraoFacade
{
    public class DvdPlayer
    {
        public void On() => Console.WriteLine("DVD Player ligado.");
        public void Play(string movie) => Console.WriteLine($"Reproduzindo filme: {movie}");
        public void Off() => Console.WriteLine("DVD Player desligado.");
    }
}
