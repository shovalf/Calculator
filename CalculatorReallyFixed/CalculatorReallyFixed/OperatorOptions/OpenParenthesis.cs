using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculatorReallyFixed
{
    [OperatorType("(", 4, OperatorTypes.Parenthesis)]
    public class OpenParenthesis: IOperatorOption
    {
    }
}
