using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Net.PatternDesign.Factory
{
    public class Platinum : ICreditCard
    {
        public int GetAnnualCharge()
        {
            return 500;
        }

        public string GetCardType()
        {
            return "Platimun BBVA";
        }

        public int GetCreditLimit()
        {
            return 50000;
        }
    }
}
