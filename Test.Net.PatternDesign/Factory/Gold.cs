using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Net.PatternDesign.Factory
{
    public class Gold : ICreditCard
    {
        public int GetAnnualCharge()
        {
            return 1000;
        }

        public string GetCardType()
        {
            return "Gold BBVA";
        }

        public int GetCreditLimit()
        {
            return 100000;
        }
    }
}
