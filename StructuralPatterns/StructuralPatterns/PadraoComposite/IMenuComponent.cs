using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.PadraoComposite
{
    public interface IMenuComponent
    {
        void Display();
        void Add(IMenuComponent component);
    }
}
