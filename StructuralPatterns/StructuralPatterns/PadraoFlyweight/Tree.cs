using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.PadraoFlyweight
{
    public class Tree
    {
        private TreeType _treeType;
        private double _x, _y;

        public Tree(double x, double y, TreeType treeType)
        {
            _x = x;
            _y = y;
            _treeType = treeType;
        }

        public void Display() => _treeType.Display(_x, _y);
    }
}
