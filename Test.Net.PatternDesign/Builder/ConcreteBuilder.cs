using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Net.PatternDesign.Builder;

namespace Test.Net.PatternDesign.Build
{
    // The Concrete Build classes follow the Build interface and provide
    // specific implementations of the building steps. Your program may have
    // several variations of Builds, implemented differently.
    public class ConcreteBuilder : IBuilder
    {
        Ticket _ticket = new Ticket();  
        // A fresh Build instance should contain a blank product object, which
        // is used in further assembly.
        public ConcreteBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            _ticket = new Ticket();
        }

        public void BuildAmount()
        {
            _ticket.Amount();
            Debug.WriteLine("Painting the amounts");
        }

        public void BuildClientInformation()
        {
            Debug.WriteLine("Painting the client informacion");
        }

        public void BuildCompanyInformation()
        {
            Debug.WriteLine("Painting the company information");
        }

        public void BuildFooter()
        {
            Debug.WriteLine("Painting the footer");
        }

        public void BuildHeader()
        {
            Debug.WriteLine("Painting the header");
        }

        public void BuildTaxes()
        {
            Debug.WriteLine("Painting the taxes");
        }

        public void BuildTotales()
        {
            Debug.WriteLine("Painting the totales");
        }
    }
}
