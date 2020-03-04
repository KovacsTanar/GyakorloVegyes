using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GyakorloVegyes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Feladat1();
            //Feladat2();
            //Feladat3();
            Feladat4();
            
        }

        static void Feladat1()
        {
            Console.WriteLine("Kérem az első számot!");
            int elso = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kérem a második számot!");
            int masodik = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Az összegük: {0}", elso + masodik);
            Console.WriteLine("A különbségük: {0}", elso - masodik);
            Console.WriteLine("A szorzatuk: {0}", elso * masodik);

            if (masodik == 0)
                Console.WriteLine("nincs hányadosuk!");
            else
                Console.WriteLine("A hányadosuk: {0}", elso / masodik);

            Console.ReadKey();
        }

        static void Feladat2()
        {
            Console.WriteLine("Kérem a kör átmérőjét!");
            double d = Convert.ToDouble(Console.ReadLine());
            double r = d / 2;

            double kerulet = 2 * r * Math.PI;
            double terulet = Math.Pow(r, 2) * Math.PI;

            Console.WriteLine("A Kerülete: {0:0.00}", kerulet);
            Console.WriteLine("A Területe: {0:0.00}", terulet);

           Console.ReadKey();

        }

        static void Feladat3()
        {
            Random rnd = new Random();

            int osszeg = 0;
            int paratlanDB = 0;
            int hatosDB = 0;

            for (int i = 0; i < 100; i++)
            {
                int dobas = rnd.Next(1, 7);
                osszeg += dobas;

                if (dobas % 2 != 0)
                    paratlanDB++;
                if (dobas == 6)
                    hatosDB++;
                
            }

            Console.WriteLine("A dobások összege: {0}",osszeg);
            Console.WriteLine("A dobások átlaga: {0:0.00}",(double)osszeg/100);
            Console.WriteLine("A páratlanok darabszáma: {0}",paratlanDB);
            Console.WriteLine("Ennyiszer dobtunk hatot: {0}",hatosDB);
            Console.ReadKey();

            Console.Clear();

            int osszeg2 = 0;
            int DB6_12 = 0;

            for (int i = 0; i < 40; i++)
            {
                int dobas1 = rnd.Next(1, 7);
                int dobas2 = rnd.Next(1, 7);
                int dobasOsszeg = (dobas1 + dobas2);

                if (dobasOsszeg > 6 && dobasOsszeg < 12)
                    DB6_12++;
                osszeg2 += dobasOsszeg;
            }

            Console.WriteLine("Ennyiszer volt nagyobb a dobásunk, mint 6, de kevesebb, mint 12: {0}",DB6_12);

            if(osszeg > osszeg2)
                Console.WriteLine("Az első sorozatnak nagyobb az összege!");
            else
                Console.WriteLine("A második sorozatnak nagyobb az összege!");
            Console.ReadKey();
        }

        static void Feladat4()
        {
            Random rnd = new Random();
            Console.WriteLine("Hányszor dobjunk?");
            int dobasokSzama = Convert.ToInt32(Console.ReadLine());

            int fej = 0;
            int iras = 0;

            for (int i = 0; i < dobasokSzama; i++)
            {
                int dobas = rnd.Next(0, 2);
                if (dobas == 0)
                    fej++;
                else
                    iras++;

            }

            Console.WriteLine("'Fej': {0}",fej);
            Console.WriteLine("'Írás': {0}",iras);

            if(fej>iras)
                Console.WriteLine("'Fejből' volt több!");
            else
                Console.WriteLine("'Írásból' volt több!");

            Console.ReadKey();
        }
    }


}
