using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orai1016
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérem, adjon meg egy 4 számjegyű kódot: ");
            int kod = int.Parse(Console.ReadLine());
            Console.Write("Kérem, adja meg a szót: ");
            string kodolando = Console.ReadLine();
            Console.WriteLine($"Átalakított szó: {Kodolo(kodolando, kod)}");
        }
        static string Kodolo (string szoveg, int szam)
        {
            string abc = "aábcdeéfghiíjklmnoóöőpqrstuúüűvwxyzaábcdeéfg";
            int eltolo = 0;
            int atalakito = 0;
            string atalakitottszo = "";
            string szamstr = szam.ToString();
            int index = 0;
            
            for (int i = 0; i < szoveg.Length; i++)
            {
                if (!abc.Contains(szoveg[i]))
                {
                    continue;
                }
                eltolo = int.Parse(szamstr[index].ToString());
                
                atalakito = abc.IndexOf(szoveg[i]);
                atalakitottszo += abc[atalakito+eltolo];
                
                if (index == 3)
                {
                    index = -1;
                }
                index ++;
                
            }
            return atalakitottszo;
        }
            
    }
}
