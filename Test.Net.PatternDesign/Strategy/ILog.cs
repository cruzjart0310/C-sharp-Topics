using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Net.PatternDesign.Strategy
{
    public interface ILog
    {
        void Save(string content);
    }
}
