using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulasPOO.Model
{
    // crie os códigos de teste para cada método construtor de conta
    // permita também criar contas informando apenas o número ou apenas o saldo
    public class Conta
    {
        private long _numero;
        private decimal _saldo;
        private Cliente _titular;
        public long Numero {
            get
            {
                return _numero;
            }
            private set
            {
                _numero = value;
            }
        }
        public decimal Saldo {
            get
            {
                return _saldo;
            }
            private set
            {
                _saldo = value;
            }
        }

        public Conta(long numero, decimal saldo)
        {
            _numero = numero;
            _saldo = saldo;
        }
        public Conta()
        {

        }
        public Cliente Titular {
            get
            {
                return _titular;
            }
            set
            {
                _titular = value;
            } 
        }
        public void Deposito(decimal valor)
        {
            Saldo += valor;

        }
        public bool Saque(decimal valor)
        {
            if(valor > Saldo)
            {
                throw new ArgumentOutOfRangeException("Valor excede saldo disponível");
            }
            Saldo -= valor;
            return true;
        }
        public void Transfere(Conta destino, decimal valor)
        {
            // como controlar a transacao para que o saque somente seja efetivado
            // com o deposito confirmado
            if (Saque(valor))
                destino.Deposito(valor);
        }
    }
}
