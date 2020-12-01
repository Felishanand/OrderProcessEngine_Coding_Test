using OrderProcessEngine.Core.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessEngine.Core
{
    public abstract class ProcessOrder
    {
        protected TypeOfRuleEnum TypeofProduct { get; }
        protected abstract TypeOfRuleEnum TypeOfRule { get; set; }
        protected ProcessOrder NextRule { get; }

        public ProcessOrder(ProcessOrder nextRule, TypeOfRuleEnum typeOfRule)
        {
            TypeofProduct = typeOfRule;
            NextRule = nextRule;
        }

        protected abstract List<TypeOfActionAgainstRule> Process();

        internal List<TypeOfActionAgainstRule> VerifyRuleAndProcess()
        {
            var listOFActions = new List<TypeOfActionAgainstRule>();
            if (TypeofProduct == TypeOfRule)
            {
                listOFActions = this.Process();
            }
            else if (NextRule != null)
            {
                listOFActions = NextRule.VerifyRuleAndProcess();
            }
            return listOFActions;
        }
    }
}