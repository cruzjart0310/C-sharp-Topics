using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Net.PatternDesign.Strategy
{
    public class DataBaseLogger : ILog
    {
        public void Save(string content)
        {
            Debug.WriteLine(content);
        }
    }
}
