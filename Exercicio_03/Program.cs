//Fazer um programa para ler quatro valores inteiros A, B, C e D.
//A seguir, calcule e mostre a diferença do produto
//de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D)
int valor1, valor2, valor3, valor4, diferenca;

Console.WriteLine("Digite 4 valores: " );

valor1 = int.Parse(Console.ReadLine());
valor2 = int.Parse(Console.ReadLine());
valor3 = int.Parse(Console.ReadLine());
valor4 = int.Parse(Console.ReadLine());

diferenca = valor1 * valor2 - valor3 * valor4;
Console.WriteLine($"DIFERENÇA: {diferenca}");