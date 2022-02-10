using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculatorReallyFixed
{
    [OperatorType("d+MainCalculator", 0, OperatorTypes.Operand)]
    public class Operand: IOperatorOption
    {
        public double Value { get; private set; }

        public Operand(double value)
        {
            Value = value;
        }
    }
}
