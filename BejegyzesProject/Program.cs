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

            Console.ReadLine();
        }
    }
}
