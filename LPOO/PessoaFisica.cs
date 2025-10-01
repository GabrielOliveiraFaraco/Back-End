using System.Globalization;

public class PessoaFisica : Pessoa
{
    public string? cpf;

    public PessoaFisica(string nome) : base(nome)
    {
        endereco = "Endereço padrão";
    }
}