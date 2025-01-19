using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.PadraoComposite
{
    public class Menu : IMenuComponent
    {
        private string _name;
        private List<IMenuComponent> _components = new List<IMenuComponent>();

        public Menu(string name) => _name = name;

        public void Display()
        {
            Console.WriteLine($"Menu: {_name}");
            foreach (var component in _components)
            {
                component.Display();
            }
        }

        public void Add(IMenuComponent component) => _components.Add(component);
    }
}
