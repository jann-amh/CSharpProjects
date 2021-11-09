namespace ChainOfLights
{
    public class LED
    {
        public bool Power { get; set; }

        public string Name { get; set; }

        public void onPower()
        {
            Power = true;
        }

        public void offPower()
        {
            Power = false;
        }

        public override string ToString()
        {
            return "Name:" + Name + " Power:" + Power;
        }
    }
}
