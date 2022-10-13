using NUnit.Framework;
using Test.Net.DataStructure.LinkedList;

namespace Test.Net.UnitTest
{
    public class UnitTestLinkedList
    {
        [Test]
        public void AddLinkedList()
        {
            //Arrange: define input
            ClLinkedList list = new ClLinkedList();

            //Act : execute actions
            list.add(3);
            list.add(5);
            list.add(7);
            list.add(9);
            list.add(11);
            list.add(15);

            //Assert : validate the results
            list.Tranverse();
            //Console.WriteLine(list.IsEmpty());

            //list.CleanList();

            //list.Tranverse();
            //Console.WriteLine(list.IsEmpty());

            //ClNode node = list.Search(15);
            //Console.WriteLine(node);

            //int index = list.SearchIndex(150);
            //Console.WriteLine(index);

            //ClNode node = list.SearchPrevious(355);
            //Console.WriteLine(node);

            //list.Delete(3);
            //list.Tranverse();

            list.Insert(0, 100);
            list.Tranverse();

            Assert.IsTrue(true);
        }
    }
}