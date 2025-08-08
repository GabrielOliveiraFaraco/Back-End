Console.WriteLine("Insira o primeiro número:");
double numero1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Insira outro número:");
double numero2 = Convert.ToDouble(Console.ReadLine());

double soma = numero1 + numero2;
double subtracao = numero1 - numero2;
double multiplicacao = numero1 * numero2;
double divisao = numero1 / numero2;

Console.WriteLine("Soma:" + soma);
Console.WriteLine($"Subtração: {subtracao}");
Console.WriteLine(string.Format("Multiplicação: {0}", multiplicacao));
Console.WriteLine(string.Format("Divisão: {0}", divisao));