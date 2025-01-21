using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioursPatterns.Interpreter
{
    public class SubtractExpression : IExpression
    {
        private IExpression _left, _right;
        public SubtractExpression(IExpression left, IExpression right) { _left = left; _right = right; }
        public int Interpret() => _left.Interpret() - _right.Interpret();
    }

}
