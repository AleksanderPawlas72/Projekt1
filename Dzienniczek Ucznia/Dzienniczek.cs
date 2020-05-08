using System;
using System.Collections.Generic;
using System.Linq;

namespace Dzienniczek_Ucznia
{
    class Dzienniczek
    {
        //stan (zmienne - pola)
        List<float> oceny = new List<float>();

        //zachowania
        public void DodawanieOcen(float ocena)
        {
            oceny.Add(ocena);
        }

        public float ObliczanieSredniej()
        {
            float suma = 0, srednia = 0;
            foreach (var ocena in oceny)
            {
                suma += ocena;

            }
            srednia = suma / oceny.Count();
            return srednia;
        }
        public float PobierzMaxOcene()
        {
            return oceny.Max();
        }
                public float PobierzMinOcene()
        {
            return oceny.Min();
        }

    }
}
