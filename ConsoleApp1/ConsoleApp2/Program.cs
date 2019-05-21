using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //EJERCICIO 2


            {
                String Com = "q";
                foreach (byte b in System.Text.Encoding.UTF8.GetBytes(Com.ToCharArray())) //asignacion al valor unicode de "q"
                    Console.Write(b.ToString());

                String Com1 = "Q";
                foreach (byte b in System.Text.Encoding.UTF8.GetBytes(Com1.ToCharArray())) //asignacion al valor unicode de "Q"
                    Console.Write(b.ToString());

                Console.ReadLine();


            }
        }
    }
}
