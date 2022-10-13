using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Net.Poo.Accesors.Virtual
{
    internal class BankCustomer: Customer
    {
        // Overriding the FullName virtual property derived from customer class
        public override string FullName
        {
            get
            {
                return "Mr. " + FirstName + " " + LastName;
            }
        }
    }
}
