using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace regular
{
    internal class LifeInsurance : InsurancePolicies
    {
        private int Age;
        public LifeInsurance(string name,int id,int age):base(name,id)
        {
            this.Age = age;
            premiumAmount = CalculatePremium();
        }
        public override double CalculatePremium()
        {
            return Age < 30 ? 700.0 : 900.0;
         
            

           
        }
    }
}
