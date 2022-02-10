using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculatorReallyFixed
{
    public class ExpressionAttributes: Attribute
    {
        private Type _expressionType;

        public ExpressionAttributes(Type expressionType)
        {
            _expressionType = expressionType;
        }

        public virtual Type ExpressionType
        {
            get { return _expressionType; }
        }
    }
}
