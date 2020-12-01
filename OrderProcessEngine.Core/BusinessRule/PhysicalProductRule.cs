using OrderProcessEngine.Core.Common;
using System.Collections.Generic;

namespace OrderProcessEngine.Core.BusinessRule
{
    public class PhysicalProductRule : ProcessOrder
    {
        internal PhysicalProductRule(ProcessOrder processOrder, TypeOfRuleEnum typeOfRule) : base(processOrder, typeOfRule)
        {
        }

        protected override TypeOfRuleEnum TypeOfRule { get; set; } = TypeOfRuleEnum.PhysicalProduct;

        protected override List<TypeOfActionAgainstRule> Process()
        {
            var result = new List<TypeOfActionAgainstRule>();
            result.Add(TypeOfActionAgainstRule.GeneratePackagingSlip);
            result.Add(TypeOfActionAgainstRule.GenerateCommission);

            return result;
        }
    }
}