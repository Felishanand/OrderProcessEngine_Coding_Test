using OrderProcessEngine.Core.Common;
using System;
using System.Collections.Generic;

namespace OrderProcessEngine.Core
{
    public class ProcessProduct
    {
        public List<TypeOfActionAgainstRule> Process(string rule)
        {
            var handleRule = new HandleRule();
            var order = handleRule.GetRuleType(rule);

            if (!order.HasValue)
                throw new Exception("Invalid Order Process");

            return (new ExcuteRuleEngine()).ExcuteRule(order.Value);
        }
    }
}