using AulasPOO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAulasPOO
{
    [TestClass]
    public class TestConta
    {
        [TestMethod]
        public void TestaDeposito()
        {
            //cenario
            decimal saldoInicial = 1000;
            long numero = 1234;
            var conta1 = new Conta(numero, saldoInicial);

            //acao
            conta1.Deposito(1000);

            //teste
            Assert.Equals(2000, conta1.Saldo);
        }
        [TestMethod]
        public void TestaSaqueDentroDoSaldo()
        {
            //cenario
            decimal saldoInical = 1000;
            long numero = 1234;
            var conta1 = new Conta(numero, saldoInical);

            //acao
            conta1.Saque(500);

            //teste
            Assert.Equals(500, conta1.Saldo);
        }

        //A.T.C.
        // Quanto houver tentativa de saque que seja maior que o saldo disponível,
        // deve ser lançada uma exceção ArgumentOutOfRangeException
        // Escreva o código de teste que intercepte esse cenário e realie a 
        // implementação na classe

        // Uma conta deve permitir que sejam realizadas transferências
        // Implemente o código de teste e o código na classe que permitam
        // realizar esta tarefa

        // 05/12
        // Podem existir contas especiais que diferentemente das contas comuns
        // possuem um limite e podem usar esse limite para saques que 
        // superem o saldo
    }
}
