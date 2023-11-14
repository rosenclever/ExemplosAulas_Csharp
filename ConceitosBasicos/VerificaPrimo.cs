using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceitosBasicos
{
    public class VerificaPrimo
    {
        public static bool Validar(int primo)
        {
            int cont = 2;
            while (cont <= primo/2) 
            {
                if (primo % cont == 0)
                {
                    return false;
                }
                cont++;
            }
            return true;
        }
    }
}
