using NUnit.Framework;
using System;
using Test.Net.General.GarbageCollector;

namespace Test.Net.UnitTest
{
    public class Tests
    {
        [Test]
        public void EstructureTest()
        {
            //Arrange: define input data

            //Act : execute actions

            //Assert : validate the results
            Console.WriteLine("EstructureTest()");
            Assert.IsTrue(true);
        }

        [Test]
        public void ExampleUsing()
        {
            using (ExampleClassDisposable instance = new ExampleClassDisposable())
            {
                instance.Example();
            }
            Assert.IsTrue(true);
        }

        [Test]
        public void ExampleWhitOutUsing()
        {
            ExampleClassDisposable instance = new ExampleClassDisposable();
            instance.Example();
            instance.Dispose();
            Assert.IsTrue(true);
        }

        [Test]
        public void ExampleDbExecution()
        {
            var connection = new ClsSqlConnection();
            var date = connection.GetDate();
            Console.WriteLine("Current Date: " + date);
            Assert.IsTrue(true);
        }

        [Test]
        public void ExampleReadWhitOutDisposed()
        {
            for (int i=0; i<1000; i++)
            {
                using (var connection = new ClsSqlConnection())
                {
                    var date = connection.GetDate();
                    Console.WriteLine("Current Date: " + date);
                }
            }

            Assert.IsTrue(true);        
        }

        [Test]
        public void ExampleReadDisposedTryFinally()
        {
            for (int i = 0; i < 1000; i++)
            {
                ClsSqlConnection connection = null;
                try
                {
                    connection = new ClsSqlConnection();
                    var date = connection.GetDate();
                    Console.WriteLine("Current Date: " + date);
                }
                finally
                {
                    connection.Dispose();
                }
            }
            Assert.IsTrue(true);
        }

        [Test]
        public void Example_Destructor()
        {
            DestructorDemo obje1 = new DestructorDemo();
            DestructorDemo obje2 = new DestructorDemo();

            obje1 = null;
            obje2 = null;

            GC.Collect();

            Assert.IsTrue(true);   
        }
    }
}