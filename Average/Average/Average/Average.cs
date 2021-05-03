using System;
using System.Collections.Generic;
using System.Text;

namespace Average
{
    class Average
    {
        private int sum;

        public int Englisch { private get; set; }

        public int Deutsch { private get; set; }

        public int Mathe { private get; set; }

        public Average(int englisch, int deutsch, int mathe)
        {
            Englisch = englisch;
            Deutsch = deutsch;
            Mathe = mathe;
        }

        public void Add()
        {
            Console.WriteLine($"{Englisch + Deutsch + Mathe / 3} ")
        }
    }
}
