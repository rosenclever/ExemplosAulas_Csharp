// See https://aka.ms/new-console-template for more information
using ConceitosBasicos;

Console.WriteLine("Hello, World!");
Somador somador = new Somador();
Console.WriteLine("Informe o primeiro número:");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Informe o segundo número:");
int num2 = Convert.ToInt32(Console.ReadLine());
var soma = somador.Somar(num1, num2);
Console.WriteLine($"Resultado da soma é {soma}");
// crie uma classe que subtraia 2 numeros inteiros
// utilize essa classe aqui
Subtracao subtracao = new Subtracao();
Console.WriteLine($"O resultado da subtração é {subtracao.Subtrair(82,40)}");

//crie uma classe calculadora que realize as 4 operações básicas

Console.WriteLine($"A multiplicação de {num1} por {num2} é {Calculadora.Multiplicar(num1,num2)}");