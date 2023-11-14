using ConceitosBasicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConceitosBasicos
{
    [TestClass]
    public class ExercicosTest
    {
        [TestMethod]
        public void TestaPrimoComValorPrimo()
        {
            //cenario
            int primo = 13;

            //acao e verificacao
            Assert.IsTrue(VerificaPrimo.Validar(primo));
        }
        [TestMethod]
        public void TestaPrimoComValorNaoPrimo()
        {
            //cenario
            int primo = 42;

            //acao e verificacao
            Assert.IsFalse(VerificaPrimo.Validar(primo));
        }
        [TestMethod]
        public void VerficaFatorial()
        {
            //cenario
            int numero = 4;
            int fatorial = 24;

            //acao e verificacao
            Assert.AreEqual(fatorial, CalculaFatorial.Calcular(numero));  
        }
    }
}
