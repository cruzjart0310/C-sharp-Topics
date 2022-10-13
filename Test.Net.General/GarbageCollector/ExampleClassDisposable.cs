using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Net.General.GarbageCollector
{
    public class ExampleClassDisposable: IDisposable
    {
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public void Example()
        {
            Console.WriteLine("Print Example");
        }
    }
}
