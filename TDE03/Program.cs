double saldo = 1000.0;
int opcao = 0;

do
{
    Console.WriteLine("Bem vindo ao nosso sistema!");
    Console.WriteLine("Escolha uma das opções abaixo:");
    Console.WriteLine("Digite 1 para consultar o saldo");
    Console.WriteLine("Digite 2 para sacar");
    Console.WriteLine("Digite 3 para depositar");
    Console.WriteLine("Digite 4 para sair");
    opcao = Convert.ToInt32(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.WriteLine($"Seu saldo é de: R$ {saldo}");
            break;
        case 2:
            Console.WriteLine("Digite o valor que deseja sacar:");
            double valorSaque = Convert.ToInt32(Console.ReadLine());
            if (valorSaque > saldo)
            {
                Console.WriteLine("Saldo insuficiente para saque.");
            }
            else
            {
                saldo -= valorSaque;
                Console.WriteLine($"Saque de R$ {valorSaque} realizado com sucesso. Novo saldo: R$ {saldo}");
            }
            break;
        case 3:
            Console.WriteLine("Digite o valor que deseja depositar:");
            double valorDeposito = Convert.ToInt32(Console.ReadLine());
            saldo += valorDeposito;
            Console.WriteLine($"Depósito de R$ {valorDeposito} realizado com sucesso. Novo saldo: R$ {saldo}");
            break;
        case 4:
            Console.WriteLine("Obrigado por usar nosso sistema. Até logo!");
            break;
    }
}while (opcao != 4);