//Fazer um programa que leia o número de um funcionário
//seu número de horas trabalhadas,
//o valor que recebe por hora e
//calcule o salário desse funcionário. A seguir,
//mostre o número e o salário do funcionário, com duas casas decimais.

Console.Write("Digite o número do funcionário: ");
string numeroFuncionario = Console.ReadLine();

Console.Write("Digite o número de horas trabalhadas: ");
float horasTrabalhadas = float.Parse(Console.ReadLine());

Console.Write("Digite o valor recebido por hora: ");
float valorRecebidoPorHora = float.Parse(Console.ReadLine());

double salario = (double) horasTrabalhadas * valorRecebidoPorHora;
Console.WriteLine($"O salário do funcionário é R$ {salario.ToString("F2")}");