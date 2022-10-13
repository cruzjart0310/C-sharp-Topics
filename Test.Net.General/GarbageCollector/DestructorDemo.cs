using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Net.General.GarbageCollector
{
    public class DestructorDemo
    {
        public DestructorDemo()
        {
            Console.WriteLine("Constructor Object Created");
        }

        ~DestructorDemo()
        {
            Console.WriteLine("Object is destroyed");
        }
    }
}
