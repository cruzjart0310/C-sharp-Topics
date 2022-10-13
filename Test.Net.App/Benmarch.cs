using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Net.App
{
    [MemoryDiagnoser(false)]
    public class Benmarch
    {
        private readonly Random _ramdom = new Random(420);
        //private int[] _items;

        [GlobalSetup]
        public void Setup()
        {
            //_items = Enumerable.Range(1, 100).Select(_ => _ramdom.Next()).ToArray();
        }

        [Benchmark]
        public List<int> OrderBy()
        {
           var items = Enumerable.Range(1, 100).Select(_ => _ramdom.Next()).ToList();
            return items.OrderBy(x => x).ToList();
        } 

        [Benchmark]
        public List<int> OrderByDesc()
        {
            var items = Enumerable.Range(1, 100).Select(_ => _ramdom.Next()).ToList();
            items.Sort();
            return items;
        } 
    }
}
