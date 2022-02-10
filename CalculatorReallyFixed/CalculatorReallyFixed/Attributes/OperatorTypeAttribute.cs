using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculatorReallyFixed
{
    public class OperatorTypeAttribute : Attribute
    {
        private string _sign;
        private int _priority;
        private OperatorTypes _type;

        public OperatorTypeAttribute(string sign, int priority, OperatorTypes type)
        {
            _sign = sign;
            _priority = priority;
            _type = type;
    }

        public virtual string Sign
        {
            get { return _sign; }
        }

        public virtual int Priority
        {
            get { return _priority; }
        }

        public virtual OperatorTypes OperatorType
        {
            get { return _type; }
        }
    }
}
