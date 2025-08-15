/* // if else

int idade = 19;

if (idade >= 18)
{
    Console.WriteLine("Você é maior de idade.");
}
else
{
    Console.WriteLine("Você é menor de idade.");
}

// if else if

double nota = 8.5;

if (nota >= 9)
{
    Console.WriteLine("Tu é o bixão mesmo!");
}
else if (nota >= 6)
{
    Console.WriteLine("Tu é bom, mas pode melhorar.");
}
else
{
    Console.WriteLine("Tu precisa estudar mais.");
}

// Switch-case

string cor = "vermelho";

switch (cor)
{
    case "vermelho":
        Console.WriteLine("A cor é vermelho!");
        break;

    case "verde":
        Console.WriteLine("A cor é verde!");
        break;

    case "azul":
        Console.WriteLine("A cor é azul!");
        break;
    default:
        Console.WriteLine("Cor desconhecida!");
        break;
}

// for loop

for (int i = 0; i < 10; i += 2)
{
    Console.WriteLine($"Contagem: {i}");
}

// while loop

int contador = 0;
while (contador < 5)
{
    Console.WriteLine($"Contador: {contador}");
    contador++;
}
 */
// do while loop

/* int contagem = 0;

do
{
    Console.WriteLine($"Contagem: {contagem}");
    contagem++;
} while (contagem > 3);
 */
// break

/* for (int i = 0; i < 10; i++)
{
    if (i == 5)
    {
        break;
    }
    Console.WriteLine($"Número: {i}");
} */

// continue

for (int i = 0; i < 10; i++)
{
    if (i % 2 != 0)
    {
        continue;
    }
    Console.WriteLine(i);
}