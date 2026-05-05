// Screen Sound
String mensagemDeBoasVindas = @"
██████╗░░█████╗░░█████╗░░██████╗  ██╗░░░██╗██╗███╗░░██╗██████╗░░█████╗░░██████╗  ░█████╗░░█████╗░
██╔══██╗██╔══██╗██╔══██╗██╔════╝  ██║░░░██║██║████╗░██║██╔══██╗██╔══██╗██╔════╝  ██╔══██╗██╔══██╗
██████╦╝██║░░██║███████║╚█████╗░  ╚██╗░██╔╝██║██╔██╗██║██║░░██║███████║╚█████╗░  ███████║██║░░██║
██╔══██╗██║░░██║██╔══██║░╚═══██╗  ░╚████╔╝░██║██║╚████║██║░░██║██╔══██║░╚═══██╗  ██╔══██║██║░░██║
██████╦╝╚█████╔╝██║░░██║██████╔╝  ░░╚██╔╝░░██║██║░╚███║██████╔╝██║░░██║██████╔╝  ██║░░██║╚█████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚═════╝░  ░░░╚═╝░░░╚═╝╚═╝░░╚══╝╚═════╝░╚═╝░░╚═╝╚═════╝░  ╚═╝░░╚═╝░╚════╝░

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░";

void ExibirMensagemDeBoasVindas()
{   
    Console.WriteLine(mensagemDeBoasVindas);
}

ExibirMensagemDeBoasVindas();

void ExibirOpcoesDoMenu()
{
    Console.WriteLine("\nEscolha uma opção:");
    Console.WriteLine("1. Registra uma banda");
    Console.WriteLine("2. mostrar todas as bandas");
    Console.WriteLine("3. para avaliação de bandas");
    Console.WriteLine("4. para exibir média de uma banda");
    Console.WriteLine("-1. Sair");
}


Console.Write("\nDigite sua opção:");
String opcaoEscolhida = Console.ReadLine()!;

int opcaoConvertida = int.Parse(opcaoEscolhida);


while (opcaoEscolhida != "-1")
{
    switch (opcaoConvertida)
    {
        case 1:
            Console.WriteLine("Opção 1 selecionada: Registra uma banda");
            break;
        case 2:
            Console.WriteLine("Opção 2 selecionada: mostrar todas as bandas");
            break;
        case 3:
            Console.WriteLine("Opção 3 selecionada: para avaliação de bandas");
            break;
        case 4:
            Console.WriteLine("Opção 4 selecionada: para exibir média de uma banda");
            break;
        default:
            Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
            break;
    }

    ExibirOpcoesDoMenu();
    Console.Write("\nDigite sua opção:");
    opcaoEscolhida = Console.ReadLine()!;
}