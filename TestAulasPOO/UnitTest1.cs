using AulasPOO.Model;

namespace TestAulasPOO
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestaConstrutorDefaultCliente()
        {
            //este c�digo verifica a cria��o de instancias da classe cliente pelo contrutor default
            //cenario
            var cliente = new Cliente();
            //a��o e teste
            Assert.IsInstanceOfType(cliente, Cliente);

        }

        [TestMethod]
        public void TestaConstrutorClienteComNome() 
        {
            //este c�digo verifica a cria��o de instancias da classe cliente informando o seu nome
        }

    }
}