using OrderProcessEngine.Core.BusinessRule;
using OrderProcessEngine.Core.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessEngine.Core
{
    public class ExcuteRuleEngine
    {
        public List<TypeOfActionAgainstRule> ExcuteRule(TypeOfRuleEnum rule)
        {
            var ruleChain = new PhysicalProductRule(null, rule);

            return ruleChain.VerifyRuleAndProcess();
        }
    }
}