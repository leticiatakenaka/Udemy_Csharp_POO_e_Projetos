//Faça um programa para ler dois valores inteiros, e 
//depois mostrar na tela a soma desses números com uma
//mensagem explicativa

int valor1, valor2, somaValores;

Console.WriteLine("Digite um valor: ");
valor1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite outro valor: ");
valor2 = int.Parse(Console.ReadLine());

somaValores = valor1 + valor2;

Console.WriteLine($"A soma de {valor1} + {valor2} é igual à {somaValores}");