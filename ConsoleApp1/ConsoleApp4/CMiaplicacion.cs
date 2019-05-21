using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class CMiaplicacion
    {
        public static void main(String[] args)
        {
            CEcuaccion ec1 = new CEcuaccion();
            ec1.ecuacion(1, -3.2, 0, 7);

            double r = ec1.ValorPara(1);
            System.Console.WriteLine(r);

            r = ec1.ValorPara(1.5);
            System.Console.WriteLine(r);


            Console.ReadKey();
        }

        
    }
}
