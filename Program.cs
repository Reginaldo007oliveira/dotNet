// See https://aka.ms/new-console-template for more information

// Print a greeting message to the console
using System.Runtime.InteropServices;

Console.WriteLine("Hello, World!");

// Declare an integer variable 'numero' and assign it the value 75
string opcao;
bool exibirMenu = true;
while (exibirMenu)
{
    Console.Clear();  // para de repetir o menu
    Console.WriteLine("Digite a sua opção");
    Console.WriteLine("1 - Cadastrar cliente");
    Console.WriteLine("2 - Buscar cliente");
    Console.WriteLine("3 - Apagar clente");
    Console.WriteLine("4 - Encerrar");

     opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Digite o nome do cliente");
            break;
        case "2":
            Console.WriteLine("Busca eficiente");
            break;
        case "3":
            Console.WriteLine("Apagar cliente");
            break;
        case "4":
            Console.WriteLine("Encerrar");
             exibirMenu = false;
            break;
           
        default:
            Console.WriteLine("Opção inválida");
              break;

    }

}