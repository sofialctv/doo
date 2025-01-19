using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.PadraoBridge
{
    public abstract class Shape
    {
        protected IColor Color;
        public Shape(IColor color) => Color = color;
        public abstract void Draw();
    }
}
