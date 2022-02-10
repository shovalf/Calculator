using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculatorReallyFixed.Expression
{
    [ExpressionAttributes(typeof(Cos))]
    public class CosOperator : IExpression
    {
        private IExpression _operand;

        public CosOperator(IExpression operand)
        {
            _operand = operand;
        }

        public double Calculate()
        {
            return Math.Cos(_operand.Calculate());
        }
    }
}
