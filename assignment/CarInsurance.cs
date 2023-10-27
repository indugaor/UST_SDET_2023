using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace regular
{
    internal class CarInsurance : InsurancePolicies
    {
        private string vechileType;
        public CarInsurance(string name,int id,string vehicleType):base(name,id)
        {
            this.vechileType = vehicleType;
            premiumAmount = CalculatePremium();
        }
        public override double CalculatePremium()
        {
            return vechileType == "Sedan" ? 1100.0 : 1700.0;
        }
    }
}
