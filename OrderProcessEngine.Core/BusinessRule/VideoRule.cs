using OrderProcessEngine.Core.Common;
using System.Collections.Generic;

namespace OrderProcessEngine.Core.BusinessRule
{
    internal class VideoRule : ProcessOrder
    {
        public VideoRule(ProcessOrder processOrder, TypeOfRuleEnum typeOfRule) : base(processOrder, typeOfRule)
        {
        }

        protected override TypeOfRuleEnum TypeOfRule { get; set; } = TypeOfRuleEnum.LearningToSkiVideo;

        protected override List<TypeOfActionAgainstRule> Process()
        {
            var videoRule = new List<TypeOfActionAgainstRule>();
            videoRule.Add(TypeOfActionAgainstRule.AddFreeAidVideoToPackagingSlip);

            return videoRule;
        }
    }
}