using NUnit.Framework;
using System;
using System.Linq;
using Test.Net.General.GarbageCollector;
using Test.Net.General.Reflection;

namespace Test.Net.UnitTest
{
    public class TestsRefelction
    {

        [Test]
        public void InitTest()
        {
            //Arrange: define input data

            //Act : execute actions

            //Assert : validate the results
            Console.WriteLine("Starting test!");
            Assert.IsTrue(true);
        }

        [Test]
        public void Validate_Data_To_Create_Report()
        {
            var data = BookData.books;

            var hasElements = data.Any();

            Assert.IsTrue(hasElements);
        }

        [Test]
        public void Validate_Generation_Report_Csv()
        {

            var data = BookData.books;
            var instance = new CsvGenerator<Book>(data, "report");

            instance.Generate();

            Assert.IsTrue(true);
        }
    }
}