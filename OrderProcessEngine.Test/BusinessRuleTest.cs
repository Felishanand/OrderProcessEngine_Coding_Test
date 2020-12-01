using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderProcessEngine.Core;
using OrderProcessEngine.Core.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessEngine.Test
{
    [TestClass]
    public class BusinessRuleTest
    {
        private ExcuteRuleEngine excuteRuleEngine = null;

        [TestInitialize]
        public void Initialize()
        {
            excuteRuleEngine = new ExcuteRuleEngine();
        }

        [TestMethod]
        public void HandlePhysicalProductOrder()
        {
            var result = excuteRuleEngine.ExcuteRule(TypeOfRuleEnum.PhysicalProduct);

            Assert.IsTrue(result.Count == 2);

            Assert.IsTrue(result.Contains(TypeOfActionAgainstRule.GenerateCommission));
            Assert.IsTrue(result.Contains(TypeOfActionAgainstRule.GeneratePackagingSlip));
        }

        [TestMethod]
        public void HandleBook()
        {
            var result = excuteRuleEngine.ExcuteRule(TypeOfRuleEnum.Book);

            Assert.IsTrue(result.Count == 2);

            Assert.IsTrue(result.Contains(TypeOfActionAgainstRule.GenerateCommission));
            Assert.IsTrue(result.Contains(TypeOfActionAgainstRule.DuplicatePackaingSlip));
        }

        [TestMethod]
        public void HandleVideo()
        {
            var result = excuteRuleEngine.ExcuteRule(TypeOfRuleEnum.LearningToSkiVideo);

            Assert.IsTrue(result.Count == 1);
            Assert.IsTrue(result.Contains(TypeOfActionAgainstRule.AddFreeAidVideoToPackagingSlip));
        }

        [TestMethod]
        public void HandleNewMemberShip()
        {
            var result = excuteRuleEngine.ExcuteRule(TypeOfRuleEnum.Membership);

            Assert.IsTrue(result.Count == 2);

            Assert.IsTrue(result.Contains(TypeOfActionAgainstRule.ActivateMembership));
            Assert.IsTrue(result.Contains(TypeOfActionAgainstRule.SendEmail));
        }

        [TestMethod]
        public void HandleUpgadeMemberShip()
        {
            var result = excuteRuleEngine.ExcuteRule(TypeOfRuleEnum.UpgradeMembership);

            Assert.IsTrue(result.Count == 2);
            Assert.IsTrue(result.Contains(TypeOfActionAgainstRule.UpgradeMembership));
            Assert.IsTrue(result.Contains(TypeOfActionAgainstRule.SendEmail));
        }

        [TestMethod]
        public void HandleParsingAndProcessing()
        {
            var productproces = new ProcessProduct();
            var result = productproces.Process("LearningToSkiVideo");

            Assert.IsTrue(result.Count == 1);
            Assert.IsTrue(result.Contains(TypeOfActionAgainstRule.AddFreeAidVideoToPackagingSlip));
        }
    }
}