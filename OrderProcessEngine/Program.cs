using System;
using System.Collections.Generic;
using OrderProcessEngine.Core;
using OrderProcessEngine.Core.Common;

namespace OrderProcessEngine
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<string> orderProcessRules = new List<string>();
            orderProcessRules.Add("PhysicalProduct");
            orderProcessRules.Add("Book");
            orderProcessRules.Add("MemberShip");
            orderProcessRules.Add("UpgradeMembership");
            orderProcessRules.Add("LearningToSkiVideo");

            foreach (string orderProcessRule in orderProcessRules)
            {
                ProcessOrder(orderProcessRule);
            }
        }

        private static void ProcessOrder(string rule)
        {
            Console.WriteLine($"Order Process Successfully For {rule}");
            var processProduct = new ProcessProduct();
            var actions = processProduct.Process(rule);

            OrderProcessResult(actions);
        }

        private static void OrderProcessResult(List<TypeOfActionAgainstRule> actions)
        {
            foreach (var action in actions)
            {
                switch (action)
                {
                    case TypeOfActionAgainstRule.ActivateMembership:
                        Console.WriteLine("Activating the membership");
                        break;

                    case TypeOfActionAgainstRule.DuplicatePackaingSlip:
                        Console.WriteLine("Generating a duplicate packing slip for the royalty department.");
                        break;

                    case TypeOfActionAgainstRule.GenerateCommission:
                        Console.WriteLine("Generating a commission payment to the agent.");
                        break;

                    case TypeOfActionAgainstRule.GeneratePackagingSlip:
                        Console.WriteLine("Generating a packing slip for shipping.");
                        break;

                    case TypeOfActionAgainstRule.SendEmail:
                        Console.WriteLine("Sending email for activation/upgrade.");
                        break;

                    case TypeOfActionAgainstRule.UpgradeMembership:
                        Console.WriteLine("Upgrading the membership.");
                        break;

                    case TypeOfActionAgainstRule.AddFreeAidVideoToPackagingSlip:
                        Console.WriteLine("Adding free “First Aid” video to the packing slip ");
                        break;
                }
            }
            Console.WriteLine(Environment.NewLine);
        }
    }
}