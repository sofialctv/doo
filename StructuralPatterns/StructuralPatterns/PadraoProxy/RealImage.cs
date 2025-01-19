using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.PadraoProxy
{
    public class RealImage : IImage
    {
        private string _filename;

        public RealImage(string filename)
        {
            _filename = filename;
            LoadFromDisk();
        }

        private void LoadFromDisk() => Console.WriteLine($"Carregando imagem {_filename}...");

        public void Display() => Console.WriteLine($"Exibindo imagem {_filename}.");
    }
}
