using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HLE.Collections;
using HLE;
using System.Net.Sockets;

namespace ListBenchmarks
{
    [MemoryDiagnoser]
    public class Bench
    {
        private const int _max = 10000000;
        [Benchmark]

        public void List()
        {
            List<long> numbers  = NumberCollection.Create(0, _max).ToList();
            List<long> numbers2 = NumberCollection.Create(0, _max).ToList();
            numbers.AddRange(numbers2); 
        }

        [Benchmark]
        public void LinkedList()
        {
            LinkedList<long> numbers = new(NumberCollection.Create(0, _max).ToList());  
            LinkedList<long> numbers2 = new(NumberCollection.Create(0, _max).ToList()); 
            foreach(long value in numbers2)
            {
                numbers.AddLast(value);
            }
        }
    }
}
