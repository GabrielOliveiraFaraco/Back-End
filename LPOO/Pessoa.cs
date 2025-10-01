using System.Runtime.CompilerServices;

public class Pessoa
{
    public string? nome;
    private int idade;

    protected string? endereco;

    public Pessoa(string novoNome)
    {
        nome = novoNome;
    }

    public Pessoa()
    {
        
    }

    public void Falar()
    {
        Console.WriteLine($"Olá, meu nome é {nome} e tenho {idade} anos.");
    }

    public int GetIdade()
    {
        return idade;
    }

    public void SetIdade(int novaIdade)
    {
        if (idade >= 0)
        {
            idade = novaIdade;
        }
        else
        {
            Console.WriteLine("Valor inválido.");
        }
        
    }
}