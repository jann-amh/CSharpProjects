namespace ChainOfLights
{
    public class LED
    {
        public bool Power { get; set; }

        public string Name { get; set; }

        public LED(bool power, string name)
        {
            Power = power;
            Name = name;
        }

        public override string ToString()
        {
            return "Name:" + Name + " Power:" + Power;
        }
    }
}
