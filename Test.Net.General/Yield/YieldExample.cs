using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Net.General.Yield
{
    public class YieldExample
    {
        public IEnumerable<string> GetItemFromList(IEnumerable<string> languajes)
        {
            foreach (var word in languajes)
            {
                yield return word;
            }
        }
    }
}
