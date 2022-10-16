using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Net.PatternDesign.Factory
{
    public class Titanium : ICreditCard
    {
        public int GetAnnualCharge()
        {
            return 100;
        }

        public string GetCardType()
        {
            return "Titanium BBVA";
        }

        public int GetCreditLimit()
        {
            return 10000;
        }
    }
}
