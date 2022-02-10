using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculatorReallyFixed
{
    class Program
    {
        static void Main(string[] args)
        {
            IGetExpression getExpression = new GetRowExpression();
            ISplitExpression splitExpression = new SplitExpressionTokens();
            IConvertExpression convertExpression = new ConvertToOperatorTypes();
            PostfixExpression getPostfixExpression = new PostfixExpression();
            PostfixCalculatorNew calculator = new PostfixCalculatorNew();
            IShowResult showResult = new ShowExprResult();

            MainCalculatorProgram MainCalculator = new MainCalculatorProgram(getExpression, splitExpression,
                convertExpression, getPostfixExpression, calculator);
            double result = MainCalculator.Calculate();
            showResult.Show(result);
        }
    }
}
