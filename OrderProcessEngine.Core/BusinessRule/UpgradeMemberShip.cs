using OrderProcessEngine.Core.Common;
using System.Collections.Generic;

namespace OrderProcessEngine.Core.BusinessRule
{
    public class UpgradeMemberShip : ProcessOrder
    {
        public UpgradeMemberShip(ProcessOrder processOrder, TypeOfRuleEnum typeOfRule) : base(processOrder, typeOfRule)
        {
        }

        protected override TypeOfRuleEnum TypeOfRule { get; set; } = TypeOfRuleEnum.UpgradeMembership;

        protected override List<TypeOfActionAgainstRule> Process()
        {
            var upgradeMemberShipRule = new List<TypeOfActionAgainstRule>();
            upgradeMemberShipRule.Add(TypeOfActionAgainstRule.UpgradeMembership);
            upgradeMemberShipRule.Add(TypeOfActionAgainstRule.SendEmail);

            return upgradeMemberShipRule;
        }
    }
}