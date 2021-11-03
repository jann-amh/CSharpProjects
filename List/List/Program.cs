namespace List;

public class Program
{
    private static void Main(string[] args)
    {
        Item bread = new(1, "bread");
        Item water = new(2, "water");
        Item milk = new(3, "milk");
        List<Item> list = new();
        list.Add(milk);
        list.Add(water);
        list.Add(bread);

        for (int i = 0; i < list.Lenght; i++)
        {
            Console.WriteLine(list[i].Name);
        }
    }
}
