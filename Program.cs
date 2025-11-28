using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NevekSzurese
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> nevek = new List<string>();
            nevek.Add("Kiss István");
            nevek.Add("Nagy elemér");
            nevek.Add("kissándorjózsef23");
            nevek.Add("   Tóth# Ilona");
            nevek.Add("Fodor Levente");
            while (true) {
                Console.Clear();
                Console.WriteLine("0 Kilépés");
                Console.WriteLine("1 Névelji szóközök levágva");
                Console.WriteLine("2 Csak nagybetűvel kezdődők");
                Console.WriteLine("3 Csak számjegy nélküliek");
                Console.WriteLine("4 Csak speciális jel nélküliek");
                Console.WriteLine("5 Legalább egy szóközt tartalmazók");
                Console.WriteLine("6 Csak rendes nevek");

                string valaszt = Console.ReadLine();
                if (valaszt == "0")
                {
                    return;
                }
                else if (valaszt == "1")
                {
                    Console.Clear();
                    foreach (string nev in nevek)
                    { 
                        Console.WriteLine(nev.TrimStart());
                    }
                }
                else if (valaszt == "2")
                {
                    Console.Clear();
                    foreach (string nev in nevek)
                    {
                        string[] darabok = nev.TrimStart().Split(' ');
                        bool jo = true;
                        foreach (string nevdarab in darabok)
                        {
                            //elemer
                            if (!char.IsUpper(nevdarab.TrimStart()[0]))
                            {
                                jo = false;
                            }
                        }
                        if (jo)
                        { 
                            Console.WriteLine(nev.TrimStart());
                        }
                    }
                }
                else if (valaszt == "3")
                {
                    Console.Clear();
                    foreach (var nev in nevek)
                    {
                        bool jo = true;
                        foreach (var karakter in nev)
                        {
                            if (char.IsDigit(karakter))
                            {
                                jo = false;
                            }
                        }
                        if (!jo)
                        {
                            Console.WriteLine(nev);
                        }
                    }
                }
                else if (valaszt == "4")
                {

                }
                else if (valaszt == "5")
                {

                }
                else if (valaszt == "6")
                {

                }
                Console.ReadKey();
            }
        }
    }
}
