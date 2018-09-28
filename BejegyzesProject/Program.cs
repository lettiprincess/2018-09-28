using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BejegyzesProject
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<Bejegyzes> bejegyzesek = new List<Bejegyzes>();

            bejegyzesek.Add(new Bejegyzes("Lettike","Almafa",24));
            bejegyzesek.Add(new Bejegyzes("Niki","Barack",12));
            //Console.WriteLine(bejegyzesek[0].Kiir());

            Console.WriteLine("Kérem adja meg hány bejegyzést szeretne hozzáadni: ");
            int bejegyzesSzam = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < bejegyzesSzam; i++)
            {
                Console.WriteLine("Kérem adja meg a nevét: ");
                string nevek = Console.ReadLine();
                Console.WriteLine("Kérem adja meg a bejegyzést: ");
                string tartalmak = Console.ReadLine();


                bejegyzesek.Add(new Bejegyzes(nevek,tartalmak,rnd.Next(bejegyzesSzam*20)));
                
            }

            for (int i = 0; i < bejegyzesek.Count; i++)
            {
                Console.WriteLine(bejegyzesek[i].Kiir());
            }

            Console.WriteLine("A második bejegyzés módosítása: ");
            bejegyzesek[1].Tartalom = Console.ReadLine();

            for (int i = 0; i < bejegyzesek.Count; i++)
            {
                Console.WriteLine(bejegyzesek[i].Kiir());
            }

            //Maximum lájk kiválasztása
            int max = 0;
            for (int i = 0; i < bejegyzesek.Count; i++)
            {
                if (bejegyzesek[i].Lajkok > max)
                {
                    max = bejegyzesek[i].Lajkok;
                }
            }
            Console.WriteLine("A legtöbb lájk {0} volt.",max);

            //35-nél több lájkot kapottak
            int db = 0;
            for (int i = 0; i < bejegyzesek.Count; i++)
            {
                if (bejegyzesek[i].Lajkok > 35)
                {
                    db++;
                }
            }
            Console.WriteLine("{0} bejegyzés volt ami 35 lájknál többet kapott.",db);

            //15-nél kevesebb lájkot kapottak
            int DB = 0;
            for (int i = 0; i < bejegyzesek.Count; i++)
            {
                if (bejegyzesek[i].Lajkok < 15)
                {
                    DB++;
                }
            }
            Console.WriteLine("{0} bejegyzés volt ami 15 lájknál kevesebbet kapott.", DB);

            //Rendezés
            
            for (int i = 0; i < bejegyzesek.Count; i++)
            {
                //Maximum lájk kiválasztása
                int max1 = i;
                for (int j = i + 1; j < bejegyzesek.Count; j++)
                {
                    if (bejegyzesek[j].Lajkok > bejegyzesek[max1].Lajkok)
                    {
                        max1 = j;
                    }
                }

                // Csere
                Bejegyzes tmp = bejegyzesek[max1];
                bejegyzesek[max1] = bejegyzesek[i];
                bejegyzesek[i] = tmp;

                Console.WriteLine(bejegyzesek[i].Kiir());
            }

            

            Console.ReadLine();
        }
    }
}
