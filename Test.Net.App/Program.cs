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
using Test.Net.PatternDesign.FactoryMethod;
using log4net.Repository.Hierarchy;
using Test.Net.PatternDesign.Factory_Method;
using log4net.Core;
using Test.Net.PatternDesign.Strategy;
using Test.Net.PatternDesign.Builder;
using Test.Net.PatternDesign.Build;
using Test.Net.PatternDesign.Singleton;
using Test.Net.PatternDesign.Prototype;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace Test.Net.App
{
    public class Program
    {
        static void Main(string[] args)
        {
            // BenchmarkRunner.Run<Benmarch>();

            //new Client().Main();

            #region  Call Strategy
            /*We can initilize our context with Default Strategy*/
            var context = new Context(new DataBaseLogger());
            context.Save("Content saved via DB");

            context.SetStrategy(new FileLogger());
            context.Save("Content saved via file");

            context.SetStrategy(new DebugLogger());
            context.Save("Context saved via debug console");
            #endregion

            #region  Call Builder
            var director = new Director();
            var builder = new ConcreteBuilder();
            director.Builder = builder;

            Debug.WriteLine("--Basic Ticket--");
            director.BuildBasicTicket();

            Debug.WriteLine("--Basic Ticket--");
            director.BuildTicketWithTaxes();

            // Remember, the Builder pattern can be used without a Director
            // class.
            Console.WriteLine("Custom product:");
            builder.BuildHeader();
            builder.BuildClientInformation();
            builder.BuildFooter();
            #endregion

            #region  Call Singleton
            Singleton instance1 = Singleton.GetInstance;
            Singleton instance2 = Singleton.GetInstance;

            if (instance1 == instance2)
            {
                Debug.WriteLine("Singleton works, both variables contain the same instance.");
            }
            else
            {
                Debug.WriteLine("Singleton failed, variables contain different instances.");
            }

            // validate if user object is null
            if (instance1.User is null)
            {
                instance1.User = new User();
                instance1.User.Id = 1;
                instance1.User.Name = "Name";
                instance1.User.Email = "emai@test.com";
            }

            //At another point in our application we can apply this validation
            if (instance1.User is null)
            { }
            else
            {
                Debug.WriteLine("user object is already set");
            }
            #endregion
        }
    }
}

