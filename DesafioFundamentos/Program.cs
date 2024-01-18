using System.Runtime.InteropServices;
using DesafioFundamentos.Models;
using DesafioFundamentos.Utilitarios;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" +
                  "Digite o preço inicial:");

while(precoInicial == 0)
{
    try{

        string precoTexto = Console.ReadLine();
        precoInicial = Convert.ToDecimal(Ferramentas.RetirarPontoParaVirgula(precoTexto));

    }catch(System.FormatException ex)
    {
        Console.WriteLine($"Valor inicial digitado foi inválido: {ex.Message} Por favor tente novamente.");
    }

    
}

Console.WriteLine("Agora digite o preço por hora:");

while(precoPorHora == 0)
{
    
    try{

        string precoTexto = Console.ReadLine();
        precoPorHora = Convert.ToDecimal(Ferramentas.RetirarPontoParaVirgula(precoTexto));

    }catch(System.FormatException ex)
    {
        Console.WriteLine($"Valor por hora digitado foi inválido: {ex.Message} Por favor tente novamente.");
    }
}



// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            es.AdicionarVeiculo();
            break;           

        case "2":
            try
            {
                es.RemoverVeiculo();    

            }catch(System.FormatException ex)
            {
                Console.WriteLine($"Valor digitado foi inválido: {ex.Message}. Por favor tente novamente.");
            }
            break;

        case "3":
            es.ListarVeiculos();
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");
