using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulasPOO.Model
{
    public class Cliente
    {
        //complemente a classe cliente conforme solicitado em program

        private string _nome;
        private string _cpf;
        public string Nome {
            get
            {
                return _nome;
            }
            private set
            {
                _nome = value;
            } 
        }
        public Cliente(string nome)
        {
            _nome = nome;
        }

        public Cliente(string nome, string cpf)
        {
            if (cpf.Length != 11)
                throw new ArgumentOutOfRangeException("CPF deve ter 11 digitos");
            _nome = nome;
            _cpf = cpf;
        }
        
        public Cliente()
        {

        }
    }
}
