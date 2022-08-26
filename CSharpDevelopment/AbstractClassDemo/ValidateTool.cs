using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    internal class ValidateTool
    {
        public static bool Validate(RuleBase ruleBase,object value)
        {
            return ruleBase.Validate(value);
        }
    }
}
