using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.CodeDom;

namespace feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1,2. feladat");
            List<string> szok = new List<string>();
            List<int> szamok = new List<int>();
            int help;
            string sor;
            StreamReader sr = new StreamReader("mindenfele.csv");
            while (!sr.EndOfStream)
            {
                sor = sr.ReadLine();
                if (int.TryParse(sor, out help))
                {
                    szamok.Add(help);
                }
                else
                    szok.Add(sor);
            }
            sr.Close();
            Console.WriteLine("3. feladat");
            var eredmeny=from szam in szamok where szam>20 select szam;
            foreach(var szam in eredmeny)
            {
                Console.WriteLine(szam);
            }
            Console.WriteLine("4. feladat");
            Dictionary<int, int> db = new Dictionary<int, int>();
            foreach (var szam in szamok)
                if (!db.TryGetValue(szam,out var a))
                    db[szam] = 1;
                else
                    db[szam]++;
            foreach(var par in db)
            {
                Console.WriteLine(par.Key+":"+par.Value);
            }
            /*Console.WriteLine("5. feladat");
            Console.WriteLine("Előtte:");
            foreach (var szo in szok)
            {
                Console.Write(szo + "|");
            }

            var kezdo = from szo in szok group szo by szo[0] into w select w;
            Console.WriteLine(kezdo);
            var lt = from k in kezdo where k == kezdo.Max() select k.Key;
            szok = (from szo in szok where szo[0] != lt.First() select szo).ToList();
            Console.WriteLine("Utána:");
            foreach (var szo in szok)
            {
                Console.Write(szo + "|");
            }*/
            Console.WriteLine("6. feladat");
            var bavg = from szam in szamok where szam < szamok.Average() select szam;
            foreach (var szam in bavg)
            {
                Console.WriteLine(szam);
            }
            Console.WriteLine("7. feladat");
            var ls = from szo in szok select new KeyValuePair<string,int>(szo,szo.ToCharArray().Count(c => c == 's'));
            var listes = ls.ToList();
            listes=listes.OrderBy(x => x.Value).ToList();
            Console.WriteLine(listes.Last().Key + "|" + listes.Last().Value);
            Console.WriteLine("9. feladat");
            Random r = new Random();
            int gep = r.Next(1, 21);
            int tipp = -1;
            while (tipp != gep)
            {
                Console.Write("Kérem a tippet:");
                tipp = Convert.ToInt32(Console.ReadLine());
                if (tipp < gep)
                    Console.WriteLine("Nagyobb");
                else
                    if (tipp > gep)
                        Console.WriteLine("Kissebb");
                else
                    break;

            }
            Console.WriteLine("Sikerült:" + tipp + "|" + gep);
            Console.ReadKey();
        }
    }
}
