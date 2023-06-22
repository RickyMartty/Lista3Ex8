using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista3_ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int d=0;
                for (int i = 1; i <=100; i++)
                {
                d = d + i;
                }
            Console.WriteLine($"A soma de todos os N° de 1 a 100 é {d}");
        }
    }
}
