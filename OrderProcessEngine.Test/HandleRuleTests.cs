using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderProcessEngine.Core.Common;

namespace OrderProcessEngine.Test
{
    [TestClass]
    public class HandleRuleTests
    {
        [TestMethod]
        public void ValidateRule()
        {
            HandleRule handleRule = new HandleRule();
            var rule = handleRule.GetRuleType("PhysicalProduct");
            Assert.IsTrue(rule != null && rule == TypeOfRuleEnum.PhysicalProduct);
        }

        [TestMethod]
        public void ValidateRule_CheckCaseSensitive()
        {
            HandleRule handleRule = new HandleRule();
            var rule = handleRule.GetRuleType("physicalproduct");
            Assert.IsTrue(rule != null && rule == TypeOfRuleEnum.PhysicalProduct);
        }

        [TestMethod]
        public void ValidateRule_CheckInvalidRule_AsInput()
        {
            HandleRule handleRule = new HandleRule();
            var rule = handleRule.GetRuleType(string.Empty);
            Assert.IsTrue(rule == null);
        }
    }
}