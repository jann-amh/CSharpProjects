namespace ASCIIConverter;

public static class Program
{
    private static void Main(string[] args)
    {
        Converter converter = new();

        string s = Console.ReadLine();

        char c = converter.GetChar(Convert.ToInt32((s)));

        Console.WriteLine(c);

    }
}