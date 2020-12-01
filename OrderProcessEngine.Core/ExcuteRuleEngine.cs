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
            var video = new VideoRule(null, rule);
            var ruleChain = new PhysicalProductRule(video, rule);

            return ruleChain.VerifyRuleAndProcess();
        }
    }
}