using OrderProcessEngine.Core.Common;
using System.Collections.Generic;

namespace OrderProcessEngine.Core.BusinessRule
{
    public class NewMemberShip : ProcessOrder
    {
        public NewMemberShip(ProcessOrder processOrder, TypeOfRuleEnum typeOfRule) : base(processOrder, typeOfRule)
        {
        }

        protected override TypeOfRuleEnum TypeOfRule { get; set; } = TypeOfRuleEnum.Membership;

        protected override List<TypeOfActionAgainstRule> Process()
        {
            var memberShipRule = new List<TypeOfActionAgainstRule>();
            memberShipRule.Add(TypeOfActionAgainstRule.ActivateMembership);
            memberShipRule.Add(TypeOfActionAgainstRule.SendEmail);

            return memberShipRule;
        }
    }
}