//Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e
//mostre:
//a) a área do triângulo retângulo que tem A por base e C por altura.
//b) a área do círculo de raio C. (pi = 3.14159)
//c) a área do trapézio que tem A e B por bases e C por altura.
//d) a área do quadrado que tem lado B.
//e) a área do retângulo que tem lados A e B
Console.Write("Digite o valor A: ");
double valorA = double.Parse(Console.ReadLine());

Console.Write("Digite o valor B: ");
double valorB = double.Parse(Console.ReadLine());

Console.Write("Digite o valor C: ");
double valorC = double.Parse(Console.ReadLine());

Console.WriteLine($"A área do triângulo retângulo é: {AreaTrianguloRetangulo(valorA, valorC).ToString("F3")}");
Console.WriteLine($"A área do círculo de raio C é: {AreaDoCirculo(valorC).ToString("F3")}");
Console.WriteLine($"A área do trapézio é: {AreaTrapezio(valorA, valorB, valorC).ToString("F3")}");
Console.WriteLine($"A área do quadrado é: {AreaQuadrado(valorB).ToString("F3")}");
Console.WriteLine($"A área do retângulo é: {AreaRetangulo(valorA, valorB).ToString("F3")}");

double AreaTrianguloRetangulo(double b, double h) => b * h / 2;

double AreaDoCirculo(double r) => 3.14159 * Math.Pow(r, 2);

double AreaTrapezio(double b, double b2, double h) => (b + b2) * h / 2;

double AreaQuadrado(double l) => l * l;

double AreaRetangulo(double b, double h) => b * h;