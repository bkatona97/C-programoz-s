using System;
using System.Collections.Generic;

namespace demogarbagecollector
{
    class Program
    {
        public class Garbage 
        {
            public static int n = 0;
            public Garbage()
            {
                n++;
            }
            ~Garbage()
            {
                n--;
            }
        }
        static void Main(string[] args)
        {
            int last;
            while (true)
            {
                last = Garbage.n;
                Garbage trash = new Garbage();
                if (last < Garbage.n)
                    Console.WriteLine(Garbage.n);
                else
                    break;
                
            }
            Console.WriteLine("Last: " + last);
            Console.ReadKey();
        }
    }
}
