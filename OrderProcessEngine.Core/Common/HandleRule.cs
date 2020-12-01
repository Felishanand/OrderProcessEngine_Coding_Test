using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessEngine.Core.Common
{
    public class HandleRule
    {
        public TypeOfRuleEnum? GetRuleType(string rule)
        {
            if (Enum.TryParse(typeof(TypeOfRuleEnum), rule, true, out object result))
            {
                return (TypeOfRuleEnum?)result;
            }
            return null;
        }
    }
}