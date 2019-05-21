using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class CEcuaccion
    {
        // el termino de mayor grado tiene de exponente el 3 fijo


        private double c3,c2,c1,c0;//coeficientes

        public void  ecuacion (double a, double b, double c ,double d)
        {
          c3 = a; c2 = b; c1 = c; c0 = d; 
        } 

        public double ValorPara(double x)
        {
            double resultado;
            resultado = c3 * x * x * x + c2 * x * x + c1 * x + c0;
            return resultado;//devolver el valor calculado...
        }



    }
}
