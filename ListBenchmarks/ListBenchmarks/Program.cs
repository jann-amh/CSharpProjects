using BenchmarkDotNet.Running;

namespace ListBenchmarks;

public class Program
{
    public static void Main()
    {
        BenchmarkRunner.Run<Bench>();
        Console.ReadLine();
    }
}
