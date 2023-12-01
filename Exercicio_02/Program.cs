//Faça um programa para ler o valor do raio de um círculo,
//e depois mostrar o valor da área deste círculo com quatro
//casas decimais conforme exemplos.
//Fórmula da área: area = π.raio2
//Considere o valor de π = 3.14159

double raioCirculo, areaCirculo, pi = 3.14159;

Console.Write("Digite o raio do círculo: ");
raioCirculo = double.Parse(Console.ReadLine());

areaCirculo = pi * Math.Pow(raioCirculo, 2);

Console.WriteLine($"A área do círculo é {areaCirculo.ToString("F4")}");
