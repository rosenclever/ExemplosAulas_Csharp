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
            Assert.AreEqual(2000, conta1.Saldo);
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
            Assert.AreEqual(500, conta1.Saldo);
        }
        [TestMethod]
        public void SaqueMaiorQueSaldoLancaArgumentOutOfRangeException()
        {
            //cenario
            decimal saldoInical = 1000;
            long numero = 1234;
            var conta1 = new Conta(numero, saldoInical);

            //acao e teste
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => conta1.Saque(1500));
        }
        [TestMethod]
        public void TestaTransferencia()
        {
            //cenario
            decimal saldoInical = 1000, valorTransferencia = 500;
            long numero = 1234, numero2 = 4321;
            var origem = new Conta(numero, saldoInical);
            var destino = new Conta(numero2, saldoInical);

            //acao
            origem.Transfere(destino, valorTransferencia);

            //
            Assert.AreEqual(500, origem.Saldo);
            Assert.AreEqual(1500, destino.Saldo);
        }
        [TestMethod]
        public void TestaSubclasseConta()
        {
            //cenario e Ação
            bool ehSubclasse = typeof(ContaCorrente).IsSubclassOf(typeof(Conta));
            //teste
            Assert.IsTrue(ehSubclasse);
        }
        [TestMethod]
        public void TestaSaqueUsandoLimite()
        {
            //cenario
            ContaCorrente conta1 = new ContaCorrente();
            conta1.Deposito(1000);
            conta1.Limite = 1000;

            //acao
            conta1.Saque(1100);

            //teste
            Assert.AreEqual(-100, conta1.Saldo);
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
