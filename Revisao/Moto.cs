public class Moto : Veiculo
{
    public int Cinindrada { get; set; }
    public bool Bagageiro { get; set; }

    public Moto(string modelo, int ano, string cor, string marca, int km, double valordiaria, int cinindrada, bool bagageiro) : base(modelo, ano, cor, marca, km, valordiaria)
    {
        Cinindrada = cinindrada;
        Bagageiro = bagageiro;
    }

    public void DarGrau()
    {
        Console.WriteLine("Randandandandandasn");
    }

    public void DarGrau(string acao)
    {
        Console.WriteLine(acao);
    }

    public override double CalcularValorTotal(int dias)
    {
        return base.CalcularValorTotal(dias) * 0.7;
    }

}