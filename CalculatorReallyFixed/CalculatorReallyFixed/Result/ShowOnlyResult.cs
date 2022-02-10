using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculatorReallyFixed
{
    public class ShowOnlyResult : IShowResult
    {
        public void Show(double result, string expression = "")
        {
            Console.WriteLine(result);
        }
    }
}
