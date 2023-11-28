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
            Assert.IsInstanceOfType(cliente, typeof(Cliente));

        }

        [TestMethod]
        public void TestaConstrutorClienteComNome() 
        {
            //este c�digo verifica a cria��o de instancias da classe cliente informando o seu nome

            //cenario
            string nome = "Fulano";
            var cliente = new Cliente(nome);

            //a��o e teste
            Assert.IsInstanceOfType(cliente, typeof(Cliente));
        }

        [TestMethod]
        public void TestaConstrutorClienteComNomeECpf()
        {
            //este c�digo verifica a cria��o de instancias da classe cliente informando o seu nome e cpf

            //cenario
            string nome = "Fulano";
            string cpf = "12345678901";
            var cliente = new Cliente(nome, cpf);

            //a��o e teste
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