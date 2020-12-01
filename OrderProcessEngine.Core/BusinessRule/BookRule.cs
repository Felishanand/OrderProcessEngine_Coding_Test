using OrderProcessEngine.Core.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessEngine.Core.BusinessRule
{
    public class BookRule : ProcessOrder
    {
        internal BookRule(ProcessOrder processOrder, TypeOfRuleEnum typeOfRule) : base(processOrder, typeOfRule)
        {
        }

        protected override TypeOfRuleEnum TypeOfRule { get; set; } = TypeOfRuleEnum.Book;

        protected override List<TypeOfActionAgainstRule> Process()
        {
            var bookRuleProcess = new List<TypeOfActionAgainstRule>();
            bookRuleProcess.Add(TypeOfActionAgainstRule.DuplicatePackaingSlip);
            bookRuleProcess.Add(TypeOfActionAgainstRule.GenerateCommission);

            return bookRuleProcess;
        }
    }
}