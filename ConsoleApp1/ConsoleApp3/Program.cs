using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //ejercicio 3

            int a = 5, c = 2, k = 3;
            double b = 1.7, d = 3.3, x = 10.5, cuattro, tresr, dosdd, rest;


            cuattro = Math.Pow(x, 4);
            tresr = Math.Pow(x, 3);
            dosdd = Math.Pow(x, 2);

            rest = (a * cuattro + b * tresr - c * dosdd + d*x + k);
            Console.WriteLine($"{rest}");



            Console.ReadLine();
        }
    }
}
