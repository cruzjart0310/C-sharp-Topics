using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Net.PatternDesign.Builder
{
    // It makes sense to use the Builder pattern only when your item are
    // quite complex and require extensive configuration.
    //
    // Unlike in other creational patterns, different concrete builders can
    // produce unrelated products. In other words, results of various builders
    // may not always follow the same interface.
    public class Ticket
    {
        public Ticket()
        {

        }
  
        public void Header() { }
        public void ClientInformation() { }
        public void Amount() { }
        public void Taxes() { }
        public void Totales() { }
        public void CompanyInformation() { }
        public void Footer() { }
    }
}
