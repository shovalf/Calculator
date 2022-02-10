using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculatorReallyFixed
{
    public class OperatorsFactoryRecursive
    {
        public Stack<IExpression> Values { get; }

        public OperatorsFactoryRecursive()
        {
            Values = new Stack<IExpression>();
        }

        public void CreateOperator(IOperatorOption[] tokens)
        {
            foreach (IOperatorOption operatorOption in tokens)
            {
                OperatorTypeAttribute MyAttribute =
                    (OperatorTypeAttribute)Attribute.GetCustomAttribute(operatorOption.GetType(), typeof(OperatorTypeAttribute));
                OperatorTypes operatorType = MyAttribute.OperatorType;
                foreach (Type type in System.Reflection.Assembly.GetExecutingAssembly().GetTypes()
                    .Where(mytype => mytype.GetInterfaces().Contains(typeof(IExpression))))
                {
                    ExpressionAttributes ExpressionAttribute =
                        (ExpressionAttributes)Attribute.GetCustomAttribute(type, typeof(ExpressionAttributes));
                    if (ExpressionAttribute.ExpressionType == operatorOption.GetType())
                    {
                        switch (operatorType)
                        {
                            case OperatorTypes.Operand:
                                Operand newOperand = (Operand)operatorOption;
                                Values.Push(new OperandExpression(newOperand.Value));
                                break;
                            case OperatorTypes.Unary:
                                Values.Push((IExpression)Activator.CreateInstance(type, Values.Pop()));
                                break;
                            case OperatorTypes.Binary:
                                Values.Push((IExpression)Activator.CreateInstance(type, Values.Pop(), Values.Pop()));
                                break;
                        }
                        break;
                    }
                }
        }
        }
    }
}
