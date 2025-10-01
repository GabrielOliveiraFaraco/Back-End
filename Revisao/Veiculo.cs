public class Veiculo
{
    public string Modelo { get; set; }
    public int Ano { get; set; }
    public string Cor { get; set; }
    public string Marca { get; set; }
    public int Km { get; set; }

    public double ValorDiaria { get; set; }
    public bool Alugado { get; set; }

    public Veiculo(string modelo, int ano, string cor, string marca, int km, double valordiaria)
    {
        Modelo = modelo;
        Ano = ano;
        Cor = cor;
        Marca = marca;
        Km = km;
        ValorDiaria = valordiaria;
    }

    public virtual double CalcularValorTotal(int dias) => ValorDiaria * dias;

}