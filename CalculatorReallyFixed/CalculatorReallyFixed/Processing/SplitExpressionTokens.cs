using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CalculatorReallyFixed
{
    public class SplitExpressionTokens : ISplitExpression
    {

        public string[] SplitExpression(string expression)
        {
            return Regex.Split(expression, "(?<=[()+*/-])|(?=[()+*/-])").Where(val => val != "").ToArray();
        }
    }
}
