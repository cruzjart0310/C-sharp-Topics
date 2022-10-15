using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Net.PatternDesign.Builder
{
    // The Builder interface specifies methods for creating the different parts
    // of the Product objects.
    public interface IBuilder
    {
        void BuildHeader();
        void BuildClientInformation();
        void BuildAmount();
        void BuildTaxes();
        void BuildTotales();
        void BuildCompanyInformation();
        void BuildFooter();
    }
}
