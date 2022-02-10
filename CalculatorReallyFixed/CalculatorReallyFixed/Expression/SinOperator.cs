using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculatorReallyFixed.Expression
{
    [ExpressionAttributes(typeof(Sin))]
    public class SinOperator : IExpression
    {
        private IExpression _operand;

        public SinOperator(IExpression operand)
        {
            _operand = operand;
        }

        public double Calculate()
        {
            return Math.Sin(_operand.Calculate());
        }
    }
}
