using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceitosBasicos
{
    public class CalculaFatorial
    {
        public static int Calcular(int numero)
        {
            int fat = 1;
            while (numero > 1)
            {
                fat *= numero;
                numero--;
            }
            return fat;
        }
    }
}
