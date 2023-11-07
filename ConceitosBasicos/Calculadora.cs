using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceitosBasicos
{
    public class Calculadora
    {
        public static int Multiplicar(int num1, int num2)
        {
            return num1 * num2; 
        }

        public static bool VerificaImpar(int n1)
        {
            return (n1%2 != 0);
        }
    }
}
