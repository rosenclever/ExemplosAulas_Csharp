/*
 * O projeto deverá conter uma classe cliente que possui nome, endereco, telefone, CPF e data de nascimento
 * A classe cliente será criada dentro de uma pasta chamada Model
 * Deverá ser possível verificar a idade do cliente a partir de um método da prória classe
 */

using AulasPOO.Model;

Cliente cliente = new Cliente("Fulano");
//cliente.Nome = "Fulano";
Console.WriteLine(cliente.Nome);

/*
 * Crie uma classe Conta, que possua o atributo e a propriedade numero e saldo
 */

var conta1 = new Conta(123456, 1000.99m);
//conta1.Numero = 123456;
//conta1.Saldo = 1000.99m;
Console.WriteLine($"Conta {conta1.Numero} com saldo {conta1.Saldo}");

var cliente1 = new Cliente("Fulano", "12345678901");

conta1.Titular = cliente1;

Console.WriteLine($"Conta {conta1.Numero} pertence a {conta1.Titular.Nome}");

