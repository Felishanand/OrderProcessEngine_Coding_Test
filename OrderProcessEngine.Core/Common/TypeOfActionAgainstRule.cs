using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessEngine.Core.Common
{
    public enum TypeOfActionAgainstRule
    {
        GeneratePackagingSlip,
        DuplicatePackaingSlip,
        ActivateMembership,
        UpgradeMembership,
        SendEmail,
        AddFreeAidVideoToPackagingSlip,
        GenerateCommission
    }
}