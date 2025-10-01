Pessoa p1 = new Pessoa("Gabriel");

// p1.nome = "Gabriel";
p1.SetIdade(19);

int idade = p1.GetIdade();

Console.WriteLine(idade);

// p1.idade = 19;

p1.Falar();

// Console.WriteLine($"Nome: {p1.nome}, Idade: {p1.idade}");

Pessoa p2 = new Pessoa("Hitori Bocchi");

// p2.nome = "Hitori Bocchi";
p2.SetIdade(18);

Console.WriteLine(p2.GetIdade());

// p2.idade = 18;

p2.Falar();

// Console.WriteLine($"Nome: {p2.nome}, Idade: {p2.idade}");


// Pessoa p3 = new Pessoa();

PessoaFisica pf = new PessoaFisica("Etnilson");

pf.SetIdade(20);
pf.nome = "Alterar";

pf.Falar();

PessoaJuridica pj = new PessoaJuridica("Joja Market");
pj.SetIdade(5);
pj.Falar();