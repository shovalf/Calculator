using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculatorReallyFixed
{
    public class ConvertToOperatorTypes: IConvertExpression
    {
        public IOperatorOption[] ConvertExpressionByTypes(string[] tokens)
        {
            List<IOperatorOption> expressionInfix = new List<IOperatorOption>();
            foreach (string token in tokens)
            {
                foreach (Type type in System.Reflection.Assembly.GetExecutingAssembly().GetTypes()
                .Where(mytype => mytype.GetInterfaces().Contains(typeof(IOperatorOption))))
                {
                    OperatorTypeAttribute MyAttribute =
                    (OperatorTypeAttribute)Attribute.GetCustomAttribute(type, typeof(OperatorTypeAttribute));
                    if (MyAttribute.Sign == token)
                    {
                        expressionInfix.Add((IOperatorOption)Activator.CreateInstance(type));
                    }
                }
                if (double.TryParse(token, out double num))
                {
                    expressionInfix.Add(new Operand(num));
                }
            }
            if (expressionInfix.Count() != tokens.Count())
            {
                Console.WriteLine("Invalid Expression");
                Environment.Exit(1);
            }
            return expressionInfix.ToArray();
        }

    }
}
