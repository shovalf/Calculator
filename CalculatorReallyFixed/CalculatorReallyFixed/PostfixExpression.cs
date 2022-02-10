using System;
using System.Collections.Generic;
using System.Linq;

namespace CalculatorReallyFixed
{
    public class PostfixExpression
    {
        private Stack<IOperatorOption> _values;
        public List<IOperatorOption> PostfixTokens { get; }

        public PostfixExpression()
        {
            PostfixTokens = new List<IOperatorOption>();
        }

        private void HandleClosingParenthesis()
        {
            IOperatorOption token = _values.Pop();
            while (token.GetType() != typeof(OpenParenthesis))
            {
                PostfixTokens.Add(token);
                token = _values.Pop();
            }
        }

        private int GetPriority(IOperatorOption val)
        {
            OperatorTypeAttribute MyAttribute =
                    (OperatorTypeAttribute)Attribute.GetCustomAttribute(val.GetType(), typeof(OperatorTypeAttribute));
            return MyAttribute.Priority;
        }

        private void HandleOperator(IOperatorOption token)
        {
            bool terminate = false;
            while (!terminate && _values.Count != 0)
            {
                IOperatorOption top = _values.Peek();
                if (top.GetType() == typeof(OpenParenthesis))
                {
                    terminate = true;
                }
                else if (GetPriority(top) < GetPriority(token))
                {
                    terminate = true;
                }
                else
                {
                    _values.Pop();
                    PostfixTokens.Add(top);
                }
            }
        }

        private void HandleEndOfStack()
        {
            while (_values.Count() != 0)
            {
                PostfixTokens.Add(_values.Pop());
            }
        }

        public IOperatorOption[] ConvertInfixToPostfix(IOperatorOption[] tokens)
        {
            _values = new Stack<IOperatorOption>();
            foreach (IOperatorOption token in tokens)
            {
                if (token.GetType() == typeof(OpenParenthesis))
                {
                    _values.Push(token);
                }
                else if (token.GetType() == typeof(ClosedParenthesis))
                {
                    HandleClosingParenthesis();
                }
                else if (token.GetType() == typeof(Operand))
                {
                    PostfixTokens.Add(token);
                }
                else
                {
                    HandleOperator(token);
                    _values.Push(token);
                }
            }
            HandleEndOfStack();
            return PostfixTokens.ToArray();
        }
    }
}
