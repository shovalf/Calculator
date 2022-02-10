using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculatorReallyFixed
{
    [OperatorType("*", 2, OperatorTypes.Binary)]
    public class Multi: IOperatorOption
    {
    }
}
