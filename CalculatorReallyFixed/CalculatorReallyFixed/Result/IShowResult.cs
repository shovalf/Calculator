using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculatorReallyFixed
{
    public interface IShowResult
    {
        void Show(double result, string expression = "");
    }
}
