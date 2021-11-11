using BenchmarkDotNet.Attributes;
using HLE.Collections;

namespace ListBenchmarks
{
    [MemoryDiagnoser]
    public class Bench
    {
        private const int _max = 10000000;
        private const int _searchValue = 750000;
        private static readonly List<long> _numbers = NumberCollection.Create(0, _max).ToList();
        private static readonly LinkedList<long> _linkedNumbers = new(NumberCollection.Create(0, _max));

        [Benchmark]
        public void FillingList()
        {
            List<long> numbers = NumberCollection.Create(0, _max).ToList();
            List<long> numbers2 = NumberCollection.Create(0, _max).ToList();
            numbers.AddRange(numbers2);
        }

        [Benchmark]
        public void FillingLinkedList()
        {
            LinkedList<long> numbers = new(NumberCollection.Create(0, _max).ToList());
            LinkedList<long> numbers2 = new(NumberCollection.Create(0, _max).ToList());
            foreach (long value in numbers2)
            {
                numbers.AddLast(value);
            }
        }

        [Benchmark]
        public void ListContains()
        {
            bool b = _numbers.Contains(_searchValue);
        }

        [Benchmark]
        public void LinkedListContains()
        {
            bool b = _linkedNumbers.Contains(_searchValue);
        }
    }
}
