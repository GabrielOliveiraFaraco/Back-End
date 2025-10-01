Console.WriteLine("Bem Vindo ao menu de locação de veículos!");
Console.WriteLine("===== MENU =====");

while (true)
{
    try
    {
        Console.WriteLine("1 - Alugar carro");
        Console.WriteLine("2 - Alugar moto");
        Console.WriteLine("3 - Sair");
        int opcao = Convert.ToInt32(Console.ReadLine());

        switch (opcao)
        {
            case 1:

                Carro carro = new Carro("Fusca", 1973, "Vermelho", "VolksWagen", 179666, 250.00, 2, "gasolina");
                Console.WriteLine($"O valor total do aluguel do {carro.Modelo} por 5 dias é: R$ {carro.CalcularValorTotal(5)}");
                break;
            case 2:
                Moto moto = new Moto("CB 500", 2020, "Preta", "Honda", 20000, 150.00, 500, true);

                moto.DarGrau();
                moto.DarGrau("Vrummmmm pa pa pa");

                Console.WriteLine($"O valor total do aluguel da {moto.Modelo} por 5 dias é: R$ {moto.CalcularValorTotal(5)}");
                break;
            case 3:
                Console.WriteLine("Saindo...");
                return;
            default:
                Console.WriteLine("Opção inválida. Tente novamente.");
                break;
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Entrada inválida. Por favor, insira um número.");
    }
}