using ChainOfLights;

namespace chainoflights;
public class Program
{
    private static void Main()
    {

        List<LED> lEDs = new()
        {
            new LED(true, "led01"),
            new LED(true, "led02"),
            new LED(true, "led03"),
        };

        foreach (LED led in lEDs)
        {
            Console.WriteLine(led);
        }

        for (int i = 0; i < lEDs.Count; i += 2)
        {
            Console.WriteLine(lEDs[i]);
        }
    }
}
