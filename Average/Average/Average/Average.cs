using System;

namespace Average
{
    internal class Average
    {
        public double Englisch { private get; set; }

        public double Deutsch { private get; set; }

        public double Mathe { private get; set; }

        public Average(double englisch, double deutsch, double mathe)
        {
            Englisch = englisch;
            Deutsch = deutsch;
            Mathe = mathe;
        }

        public void AverageCalculate()
        {
            double solution = (Englisch + Deutsch + Mathe) / 3;
            Console.WriteLine($"Der Druchschnitt beträgt { solution }");
            
            if(solution < 4)
            {
                Console.WriteLine("Bestanden!");
            }
            else
            {
                Console.WriteLine("Nicht bestanden!");
            }
        }
    }
}
