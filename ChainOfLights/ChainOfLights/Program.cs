using ChainOfLights;

namespace chainoflights;
public class Program
{
    private static void Main()
    {
        List<LED> lEDs = new()
        {
            new LED() { Power = true, Name = "led01" },
            new LED() { Power = true, Name = "led02" },
            new LED() { Power = true, Name = "led03" },
        };

        foreach (LED led in lEDs)
        {
            Console.WriteLine(led);
        }
    }
}
