using System;
using Test.Net.Utilities.Log4Net;
using Test.Net.General;
using Test.Net.General.ParameterValueRefence;
using Test.Net.General.GarbageCollector;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BenchmarkDotNet.Running;
using System.Diagnostics;
using Microsoft.Diagnostics.Tracing.Parsers.MicrosoftWindowsWPF;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace Test.Net.App
{
    public class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<Benmarch>();

            #region parameter by value
            //int currentValue = 10;
            //Parameter.UpdateRef(ref currentValue);
            //Console.WriteLine($"value is:{currentValue}");
            //Console.ReadKey();

            #endregion

            #region example log4net
            //Console.WriteLine("Hello world");
            //Log.Error("Log error example");
            //Console.ReadLine();
            #endregion
        }
    }
}
