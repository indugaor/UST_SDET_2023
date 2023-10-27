using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace regular
{
    internal abstract class InsurancePolicies
    {
        public string? policyName;
        public int policyId;
        public double premiumAmount;
        public InsurancePolicies(string Name,int Id)
        {
            this.policyName = Name;
            this.policyId = Id;
            
        }
        public abstract double CalculatePremium();
        public void DisplayPolicyDetails()
        {
            Console.WriteLine("Policy Name:" + policyName);
            Console.WriteLine("Policy Id:" + policyId);
            Console.WriteLine("Premium Amount:$" + premiumAmount);
        }
    }
}
