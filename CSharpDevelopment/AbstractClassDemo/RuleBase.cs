using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    abstract class RuleBase
    {
        public string? ErrorMessage { get; set; }
        public abstract bool Validate(object value);
    }

    class RequiredRule : RuleBase
    {
        public override bool Validate(object value)
        {
           bool result= value != null;

            if (!result)
                ErrorMessage = "Bu field is required";

            return result;
        }
    }

    class LengthRule : RuleBase
    {
        private readonly int _length;

        public LengthRule(int lenght)
        {
            _length = lenght;
        }

        public override bool Validate(object value)
        {
            return value != null && value.ToString().Length == _length;
        }
    }
}
