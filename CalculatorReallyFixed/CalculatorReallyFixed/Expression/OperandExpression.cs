using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculatorReallyFixed
{
    [ExpressionAttributes(typeof(Operand))]
    public class OperandExpression : IExpression
    {
        private double _val;

        public OperandExpression(double val)
        {
            _val = val;
        }

        public double Calculate()
        {
            return _val;
        }
    }
}
