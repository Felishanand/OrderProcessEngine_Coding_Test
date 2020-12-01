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
            var newMemberShip = new NewMemberShip(video, rule);
            var upgradeMemberShip = new UpgradeMemberShip(newMemberShip, rule);
            var book = new BookRule(upgradeMemberShip, rule);
            var ruleChain = new PhysicalProductRule(book, rule);

            return ruleChain.VerifyRuleAndProcess();
        }
    }
}