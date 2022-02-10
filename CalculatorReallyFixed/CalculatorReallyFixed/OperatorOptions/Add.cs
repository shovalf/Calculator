using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculatorReallyFixed
{
    [OperatorType("+", 1, OperatorTypes.Binary)]
    public class Add: IOperatorOption
    {
    }
}
