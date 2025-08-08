/* int numeroInteiro = 10;

double numeroDouble = numeroInteiro;

double pi = 3.14;

int numInt = (int)pi;


string numTexto = "123";

int numero = Convert.ToInt32(numTexto);

//Formatação de strings
//Concatenação

string nome = "Gabriel";
string mensagem = "Olá, meu nome é " + nome + "!";

//Interpolação de strings

string outroNome = "Tsuki";
int indade = 19;
string outraMensagem = $"Olá, meu nome é {outroNome}! E tenho {indade} anos!";

//Placeholders

string novoNome = "Y209R";
int idade = 20;
string novaMensagem = string.Format("Olá, meu nome é {0}! E tenho {1} anos!", novoNome, idade); */



Console.WriteLine("Informe o seu nome: ");

string? nome = Console.ReadLine();

Console.WriteLine("Informe a sua idade: ");

int idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Seu nome é {nome} e sua idade é {idade} anos!");