
using System;
using System.Security.Claims;

namespace ProjektHello
{
    class Program
    {
        static void Main(string[] args)
        {

            valueTypes();
            for (; ; )
            {
                Przywitanie();
                Wiek();
                Ustawienia();

                //foreach (var item in args)
                //{
                //    Console.WriteLine("Witaj " + item);

                //}

            }

        }

        private static void valueTypes()
        {
            int maxInt = int.MaxValue;
            int minInt = int.MinValue;
            long maxLong = long.MaxValue;
            long minLong = long.MinValue;
            Console.WriteLine("maxInt = " + maxInt);
            Console.WriteLine("minInt = " + minInt);
            Console.WriteLine("maxLong = " + maxLong);
            Console.WriteLine("minLong = " + minLong);

           // throw new NotImplementedException();
        }

        /// <summary>
        /// ustawienia początkowe
        /// </summary>
        private static void Ustawienia()
        {
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
        }

        /// <summary>
        /// wypisujemy komunikat zalezny od dzwieku
        /// </summary>
        private static void Wiek()
        {
            Console.WriteLine("Podej wiek ");

            int age;
            bool result = int.TryParse(Console.ReadLine(), out age);

            if (age > 18)
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("Brawo masz >18 - browar");
            }
            else if (result == false)
            {

                Console.WriteLine("niepoprawny wiek ");
            }
            else
            {
                Console.WriteLine("Mleko ");
            }
        }

        /// <summary>
        /// wypisujemy przywitanie uzytkownika
        /// </summary>

        private static void Przywitanie()
        {
            Console.WriteLine("Wpisz swoje imie: ");
            string name = Console.ReadLine();
            Console.WriteLine("Cześć " + name);
        }
    }
}
