using System;

namespace Dzienniczek_Ucznia
{
    class Program
    {
        static void Main(string[] args)
        {
            Dzienniczek dzienniczek = new Dzienniczek();
            //dzienniczek.DodawanieOcen(5);
            //dzienniczek.DodawanieOcen(8.5f);
            //dzienniczek.DodawanieOcen(4.7f);

            //float srednia = dzienniczek.ObliczanieSredniej();
            //float max = dzienniczek.PobierzMaxOcene();
            //float min = dzienniczek.PobierzMinOcene();

            for (; ; )
            {
                Console.WriteLine("Podaj ocene z zakresu 1 do 10 ");

                float ocena;
                bool wynik = float.TryParse(Console.ReadLine(),out ocena);
               
                
                if (ocena == 11)
                {
                    break;
                }

                if (wynik)
                {
                    if (ocena>0 && ocena<=10)
                    {
                        dzienniczek.DodawanieOcen(ocena);
                    }
                    else
                    {
                        Console.WriteLine("Zła liczba, podaj z zakresu 1-10 ");
                    }
                }


            }
            Console.WriteLine("srednia: " + dzienniczek.ObliczanieSredniej());
            Console.WriteLine("najwyzsza: " + dzienniczek.PobierzMaxOcene());
            Console.WriteLine("najniższa: " + dzienniczek.PobierzMinOcene());

            Console.ReadKey();

            Dzienniczek dzienniczek2 = new Dzienniczek();
            Dzienniczek dzienniczek3 = new Dzienniczek();
            Dzienniczek dzienniczek4 = new Dzienniczek();
            Dzienniczek dzienniczek5 = new Dzienniczek();
            Dzienniczek dzienniczek6 = new Dzienniczek();

        }
    }


}
