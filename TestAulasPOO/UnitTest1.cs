using AulasPOO.Model;

namespace TestAulasPOO
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestaConstrutorDefaultCliente()
        {
            //este código verifica a criação de instancias da classe cliente pelo contrutor default
            //cenario
            var cliente = new Cliente();
            //ação e teste
            Assert.IsInstanceOfType(cliente, Cliente);

        }

        [TestMethod]
        public void TestaConstrutorClienteComNome() 
        {
            //este código verifica a criação de instancias da classe cliente informando o seu nome
        }

    }
}