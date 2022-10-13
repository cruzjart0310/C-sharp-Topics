using NUnit.Framework;
using System;
using System.Diagnostics;
using Test.Net.DataStructure.BubbleSort;
using Test.Net.General.Delegate;
using Test.Net.General.ManageFiles;

namespace Test.Net.UnitTest
{
    public class UnitTestFile
    {

        [Test]
        public void UnitTestWriteFileUsingStreamReader()
        {
            //Arrange: define input
            ExampleFile instance = new ExampleFile();

            //Act : execute actions
            instance.WriteStreamReaderFile();

            //Assert : validate the results
            Assert.IsTrue(true);
        }

        [Test]
        public void UnitTestReadFileUsingStreamReader()
        {

            //Arrange: define input
            ExampleFile instance = new ExampleFile();

            //Act : execute actions
            instance.ReadStreamReaderFile();

            //Assert : validate the results
            Assert.IsTrue(true);
        }
    }
}