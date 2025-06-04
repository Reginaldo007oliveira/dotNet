 // See https://aka.ms/new-console-template for more information

// Print a greeting message to the console
Console.WriteLine("Hello, World!");

// Declare an integer variable 'numero' and assign it the value 75
int soma = 0, numero = 0;

do
{
    Console.WriteLine("Digite um numero");
   numero = Convert.ToInt32(Console.ReadLine());
    soma += numero;
}

while (numero != 0);

Console.WriteLine($"Total da soma dos números é:{soma}", "viu");