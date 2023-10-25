using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace regular
{
    internal class InsurancePolicy
    {
        private string? policyName;
        private int policyId;
        private double premiumAmount;

        public InsurancePolicy(string? policyName, int policyId, double premiumAmount)
        {
            policyName = policyName;
            policyId = policyId;
            premiumAmount = premiumAmount;
        }
        public void RenewPolicy(double newPremium)
        {
            premiumAmount = newPremium;
            Console.WriteLine("Policy has been renewed with a new premium of $" + newPremium);

        }
        public void RenewPolicy()
        {
            double increasedPremium = premiumAmount + (premiumAmount * 0.10);
            premiumAmount = increasedPremium;
            Console.WriteLine("Policy has been automatically renewed with a 10% premium. New premium: $" + increasedPremium);

        }
        public void DisplayPolicy()
        {
            double increasedPremium = premiumAmount + (premiumAmount * 0.10);
            premiumAmount = increasedPremium;
            Console.WriteLine("Policy has been automatically renewed with a 10% premium. New premium:$" + increasedPremium);

        }
        public void DisplayPolicyDetails()
        {
            Console.WriteLine("Policy Name:" + policyName);
            Console.WriteLine("Policy Id:" + policyId);
            Console.WriteLine("Current Premium: $" + premiumAmount);
        }
    }

}
