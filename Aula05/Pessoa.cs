public class Pessoa
{
    private int _idade;

    public int Idade
    {
        get { return _idade; }
        set
        {
            if (value >= 0)
            {
                _idade = value;
            }
        }
    }
    public string? Nome { get; set; }
    public string? cpf { get; } = "000.000.000-000";
}

