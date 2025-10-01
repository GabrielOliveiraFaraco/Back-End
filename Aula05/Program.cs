using System.Collections;

Pessoa p1 = new Pessoa();
p1.Idade = 19;
string? t = p1.cpf;

Pessoa p2 = new Pessoa();
p2.Idade = 25;

Pessoa p3 = new Pessoa();
p3.Idade = 30;

List<Pessoa> pessoas = new List<Pessoa>();

var pessoasDeMaior = pessoas.Where(p => p.Idade >= 18).ToList();

int[] numeros = new int[3];

numeros[0] = 10;
numeros[1] = 20;
numeros[2] = 30;

int[] valores = new int[] { 10, 20, 30 };

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine(numeros[i]);
}

foreach (int n in numeros)
{
    Console.WriteLine(n);
}

List<string> nomes = new List<string>();
nomes.Add("Ana");
nomes.Add("Bia");
nomes.Add("Carlos");
nomes.Remove("Bia");

bool contemBia = nomes.Contains("Bia");

foreach (var nome in nomes)
{
    Console.WriteLine(nome);
}

ArrayList lista = new ArrayList();
lista.Add(10);
lista.Add("Texto");
lista.Add(3.14);
lista.Add(p1);
