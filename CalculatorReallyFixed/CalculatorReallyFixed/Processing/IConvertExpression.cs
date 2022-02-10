using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculatorReallyFixed
{
    public interface IConvertExpression
    {
        IOperatorOption[] ConvertExpressionByTypes(string[] tokens);
    }
}
