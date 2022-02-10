using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculatorReallyFixed
{
    public class OperatorsAttribute : Attribute
    {
        private OperatorTypes _type;

        public OperatorsAttribute(OperatorTypes type)
        {
            _type = type;
        }

        public virtual OperatorTypes OperatorType
        {
            get { return _type; }
        }
    }
}
