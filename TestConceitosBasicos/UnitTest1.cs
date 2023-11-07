using ConceitosBasicos;

namespace TestConceitosBasicos
{
    [TestClass]
    public class UnitTest1
    {
        private int num1, num2, resultado;

        [TestMethod]
        public void TestaSomaDoisNumerosInteiros()
        {
            //cenario
            InicializaVariaveis();
            Somador somador = new Somador();

            //acao
            resultado = somador.Somar(num1, num2);

            //verificacao
            Assert.AreEqual(42, resultado);

        }

        [TestMethod]
        public void TestaSubtracaoDoisNumerosInteiros()
        {
            //cenario
            InicializaVariaveis();
            var subtracao = new Subtracao();

            //acao
            resultado = subtracao.Subtrair(num1, num2);

            //teste
            Assert.AreEqual(-2, resultado);
        }

        [TestMethod]
        public void VerificaNumeroPar()
        {
            //cenario e ação
            bool verifica = Calculadora.VerificaImpar(num1);

            //verificacao
            Assert.IsFalse(verifica);
        }
        [TestMethod]
        public void VerificaNumeroImpar()
        {
            //cenario e ação
            bool verifica = Calculadora.VerificaImpar(++num1);

            //verificacao
            Assert.IsTrue(verifica);
        }

        private void InicializaVariaveis()
        {
            num1 = 20;
            num2 = 22;
        }
    }
}