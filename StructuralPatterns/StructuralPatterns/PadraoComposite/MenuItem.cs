using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.PadraoComposite
{
    public class MenuItem : IMenuComponent
    {
        private string _name;
        public MenuItem(string name) => _name = name;
        public void Display() => Console.WriteLine(_name);
        public void Add(IMenuComponent component) => throw new NotImplementedException();
    }
}
