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
            Assert.IsInstanceOfType(cliente, typeof(Cliente));

        }

        [TestMethod]
        public void TestaConstrutorClienteComNome() 
        {
            //este código verifica a criação de instancias da classe cliente informando o seu nome

            //cenario
            string nome = "Fulano";
            var cliente = new Cliente(nome);

            //ação e teste
            Assert.IsInstanceOfType(cliente, typeof(Cliente));
        }

        [TestMethod]
        public void TestaConstrutorClienteComNomeECpf()
        {
            //este código verifica a criação de instancias da classe cliente informando o seu nome e cpf

            //cenario
            string nome = "Fulano";
            string cpf = "12345678901";
            var cliente = new Cliente(nome, cpf);

            //ação e teste
            Assert.IsInstanceOfType(cliente, typeof(Cliente));
        }
        [TestMethod]
        public void TestaCpfDiferenteDeOnzeDigitos()
        {
            //cenario
            string nome = "Fulano";
            string cpf = "1234567890";
            //var cliente = new Cliente(nome, cpf);

            //acao e teste
            Assert.ThrowsException<ArgumentOutOfRangeException>( () => new Cliente(nome, cpf));
        }

    }
}