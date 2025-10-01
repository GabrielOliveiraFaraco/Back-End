public class Carro : Veiculo
{
    public int NumPortas { get; set; }
    public string TipoCombustivel { get; set; }


    public Carro(string modelo, int ano, string cor, string marca, int km, double valordiaria, int numPortas, string tipoCombustivel) : base(modelo, ano, cor, marca, km, valordiaria)
    {
        NumPortas = numPortas;
        TipoCombustivel = tipoCombustivel;
    }

    public override double CalcularValorTotal(int dias)
    {
        if (TipoCombustivel.ToLower() == "gasolina")
        {
            return base.CalcularValorTotal(dias) * 1.1;
        } else if (TipoCombustivel.ToLower() == "diesel")
        {
            return base.CalcularValorTotal(dias) * 1.05;
        }
        else
        {
            return base.CalcularValorTotal(dias);
        }
    }
}