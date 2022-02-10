using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculatorReallyFixed.Expression
{
    [ExpressionAttributes(typeof(Sub))]
    public class SubOperator : IExpression
    {
        private IExpression _right;
        private IExpression _left;

        public SubOperator(IExpression left, IExpression right)
        {
            _right = right;
            _left = left;
        }

        public double Calculate()
        {
            return _right.Calculate() - _left.Calculate();
        }
    }
}
