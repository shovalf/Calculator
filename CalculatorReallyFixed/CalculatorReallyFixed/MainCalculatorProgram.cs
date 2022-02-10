using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculatorReallyFixed
{
    public class MainCalculatorProgram
    {
        private IGetExpression _getExpression;
        private ISplitExpression _splitExpression;
        private IConvertExpression _convertExpression;
        private PostfixExpression _getPostfixExpression;
        private PostfixCalculatorNew _calculator;

        public MainCalculatorProgram(IGetExpression getExpression, ISplitExpression splitExpression,
            IConvertExpression convertExpression, PostfixExpression getPostfixExpression,
            PostfixCalculatorNew calculator)
        {
            _getExpression = getExpression;
            _splitExpression = splitExpression;
            _convertExpression = convertExpression;
            _getPostfixExpression = getPostfixExpression;
            _calculator = calculator;
        }

        public double Calculate()
        {
            string expression = _getExpression.Process();
            string[] expressionTokens = _splitExpression.SplitExpression(expression);
            IOperatorOption[] expressionTypes = _convertExpression.ConvertExpressionByTypes(expressionTokens);
            IOperatorOption[] postfixExpression = _getPostfixExpression.ConvertInfixToPostfix(expressionTypes);
            return _calculator.Calculate(postfixExpression);
        }
    }
}
