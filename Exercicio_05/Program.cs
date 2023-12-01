//Fazer um programa para ler o código de uma peça X, o número de peças X, o valor unitário de cada peça X, o
//código de uma peça Y, o número de peças Y e o valor unitário de cada peça Y.
//Calcule e mostre o valor a ser pago.

Console.Write("Digite o código da peça X: ");
string codigoPecaX = Console.ReadLine();

Console.Write("Digite o número de peças X: ");
int numeroDePecasX = int.Parse(Console.ReadLine());

Console.Write("Digite o valor unitário da peça X: R$ ");
double valorUnitarioPecaX = double.Parse(Console.ReadLine());

Console.Write("Digite o código da peça Y: ");
string codigoPecaY = Console.ReadLine();

Console.Write("Digite o número de peças Y: ");
int numeroDePecasY = int.Parse(Console.ReadLine());

Console.Write("Digite o valor unitário da peça Y: R$ ");
double valorUnitarioPecaY = double.Parse(Console.ReadLine());

double valorASerPago = (valorUnitarioPecaX * numeroDePecasX) + (valorUnitarioPecaY * numeroDePecasY);

Console.WriteLine("Código\tNº\tValor\n");
Console.WriteLine($"{codigoPecaX}\t{numeroDePecasX}\tR$ {valorUnitarioPecaX}");
Console.WriteLine($"{codigoPecaY}\t{numeroDePecasY}\tR$ {valorUnitarioPecaY}");

Console.WriteLine($"\n\nValor a ser pago: R$ {valorASerPago}");