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
            return "Name" + Name + "Power" + Power;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            LED objAsPart = obj as LED;
            if (objAsPart == null) return false;
            else return Equals(objAsPart);
        }

        public bool Equals(LED other)
        {
            if (other == null) return false;
            return (this.Name.Equals(other.Name));
        }
    }
}
