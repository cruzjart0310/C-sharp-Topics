using System;
using System.Diagnostics;

namespace Test.Net.Utilities
{
    public static class Watcher
    {
        static Stopwatch stopwatch = new Stopwatch();
        public static void Init()
        {
            stopwatch.Start();    
        }

        public static void Stop()
        {
            stopwatch.Stop();
            Console.WriteLine("Exceution Time in MS :" + stopwatch.ElapsedMilliseconds);
        }
    }
}
