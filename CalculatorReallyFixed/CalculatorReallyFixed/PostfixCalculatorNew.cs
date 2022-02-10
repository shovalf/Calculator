using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculatorReallyFixed
{
    public class PostfixCalculatorNew
    {
        private Stack<IExpression> _values;
        private OperatorsFactoryRecursive _operatorsFactory;

        public PostfixCalculatorNew()
        {
            _values = new Stack<IExpression>();
            _operatorsFactory = new OperatorsFactoryRecursive();
        }

        public double Calculate(IOperatorOption[] tokens)
        {
            _operatorsFactory.CreateOperator(tokens);
            return _operatorsFactory.Values.Peek().Calculate();
        }
    }
}
