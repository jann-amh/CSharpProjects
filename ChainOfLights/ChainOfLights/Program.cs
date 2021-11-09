using ChainOfLights;

namespace chainoflights;
public class Program
{
    private static void Main()
    {
        List<LED> lEDs = new List<LED>();

        lEDs.Add(new LED() { Power = true, Name = "led01" });
        lEDs.Add(new LED() { Power = true, Name = "led02" });
        lEDs.Add(new LED() { Power = true, Name = "led03" });

        foreach (LED led in lEDs)
        {
            Console.WriteLine(led);
        }
    }
}