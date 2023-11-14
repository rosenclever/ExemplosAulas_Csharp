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
            Assert.IsTrue(VerificarPrimo.Validar(primo));
        }
    }
}
