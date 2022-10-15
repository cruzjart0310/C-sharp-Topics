using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Net.PatternDesign.Builder
{
    // The Director is only responsible for executing the building steps in a
    // particular sequence. It is helpful when producing products according to a
    // specific order or configuration. Strictly speaking, the Director class is
    // optional, since the client can control builders directly.
    public class Director
    {
        private IBuilder _builder;

        public IBuilder Builder
        {
            set { _builder = value; }
        }

        // The Director can construct several product variations using the same
        // building steps.
        public void BuildBasicTicket()
        {
            this._builder.BuildHeader();
            this._builder.BuildAmount();
            this._builder.BuildFooter();
        }

        public void BuildTicketWithTaxes()
        {
            this._builder.BuildHeader();
            this._builder.BuildAmount();
            this._builder.BuildTaxes();
            this._builder.BuildFooter();
        }
    }
}
