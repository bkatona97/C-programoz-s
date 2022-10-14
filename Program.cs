using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace codewars_functions
{
    public static class Kata
    {
        public static string Likes(string[] name)
        {
            switch (name.Length)
            {
                case 0:
                    {
                        return "no one likes this";
                    }
                case 1:
                    {
                        return name[0]+" likes this";
                    }
                case 2:
                    {
                        return name[0]+" and "+name[1]+" like this";
                    }
                case 3:
                    {
                        return name[0]+", "+name[1] + " and " + name[2] + " like this";
                    }
                default:
                    {
                        return name[0] + ", " + name[1] + " and " +(name.Length-2) + " others like this";
                    }

            }
            throw new NotImplementedException();
        }

        public static bool IsTriangle(int a, int b, int c)
        {
            if (a + b > c && c + b > a && a + c > b)
                return true;
            return false;
        }

        public static int FindShort(string s)
        {
            string []words = s.Split(' ');
            Array.Sort(words, (x, y) => x.Length.CompareTo(y.Length));
            return words[0].Length;
        }

        public static string Rgb(int r, int g, int b)
        {
            if (r > 255)
                r = 255;
            if (g > 255)
                g = 255;
            if (b > 255)
                b = 255;
            if (r < 0)
                r = 00;
            if (g < 0)
                g = 00;
            if (b < 0)
                b = 00;
            string rh=r.ToString("X"), gh = g.ToString("X"), bh = b.ToString("X");
            if (rh.Length == 1)
                rh = "0"+rh;
            if (bh.Length == 1)
                bh = "0"+bh;
            if (gh.Length == 1)
                gh = "0"+gh;

            return rh+gh+bh;
        }

        public static string[] dirReduc(String[] arr)
        {
            List<string> go = new List<string>(arr);
            for(int i=0;i<go.Count-1;i++)
                if (opposite(go[i], go[i+1]))
                {
                    go.RemoveAt(i+1);
                    go.RemoveAt(i);
                    i = -1;
                }
            return go.ToArray();
        }
        public static bool opposite(string way1,string way2)
        {
            if ((way1 == "NORTH" && way2 == "SOUTH") || (way1 == "SOUTH" && way2 == "NORTH") || (way1 == "WEST" && way2 == "EAST") || (way1 == "EAST" && way2 == "WEST"))
                return true;
            else
                return false;
        }

        public static string Order(string words)
        {
            if (words.Length == 0)
                return "";
            List<string> s =new List<string>( words.Split(' '));
            int[] ord = new int[s.Count];
            string[] help = new string[s.Count];
            string ret = "";
            for (int i = 0; i < s.Count; i++)
            {
                for (int j = 0; j < s[i].Length; j++)
                {
                    if (isNumber(s[i][j]))
                    {
                        ord[i] = Convert.ToInt32(s[i][j].ToString());
                        break;
                    }
                }
            }
            for (int i = 0; i < ord.Length; i++)
            {
                help[ord[i] - 1] = s[i];
            }
            for (int i = 0; i < ord.Length; i++)
            {
                ret += help[i]+" ";
            }
            ret = ret.Trim();
            return ret;
                throw new NotImplementedException();
        }

        public static bool isNumber(char c)
        {
            switch (c)
            {
                case '1':
                    {
                        return true;
                    }
                case '2':
                    {
                        return true;
                    }
                case '3':
                    {
                        return true;
                    }
                case '4':
                    {
                        return true;
                    }
                case '5':
                    {
                        return true;
                    }
                case '6':
                    {
                        return true;
                    }
                case '7':
                    {
                        return true;
                    }
                case '8':
                    {
                        return true;
                    }
                case '9':
                    {
                        return true;
                    }
                default:
                    {
                        return false;
                    }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Kata.FindShort("bitcoin take over the world maybe who knows perhaps"));
            //string[] a = new string[] { "NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH", "WEST" };
            //string[] a = new string[] { "NORTH", "WEST", "SOUTH", "EAST" };
            /*string[] h = Kata.dirReduc(a);
            for (int i = 0; i < h.Length; i++)
                Console.Write(h[i]+"|");
            Console.WriteLine();*/
            Console.WriteLine(Kata.Order("is2 Thi1s T4est 3a"));
            Console.WriteLine(Kata.Order("4of Fo1r pe6ople g3ood th5e the2"));

            Console.ReadKey();
        }
    }
}
