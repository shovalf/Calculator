using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculatorReallyFixed
{
    public class GetRowEnterExpression : IGetExpression
    {
        public string Process()
        {
            string str;
            string expression = "";
            do
            {
                str = Console.ReadLine();
                expression += str;
            } while (str != "");
            return expression;
        }
    }
}
