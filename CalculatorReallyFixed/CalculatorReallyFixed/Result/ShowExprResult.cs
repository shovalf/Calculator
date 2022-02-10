﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculatorReallyFixed
{
    public class ShowExprResult : IShowResult
    {
        public void Show(double result, string expression = "")
        {
            Console.WriteLine($"{expression} = {result}");
        }
    }
}
