using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulasPOO.Model
{
    public class ContaCorrente : Conta
    {
        public decimal Limite { get; set; }
        public override bool Saque(decimal valor)
        {
            if (valor > Saldo + Limite)
            {
                throw new ArgumentOutOfRangeException("Valor excede saldo disponível");
            }
            Saldo -= valor;
            return true;
        }
    }
}
