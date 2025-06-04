 // See https://aka.ms/new-console-template for more information

// Print a greeting message to the console
Console.WriteLine("Hello, World!");

// Declare an integer variable 'numero' and assign it the value 75
int numero = 75;
int contador = 1;

// Loop from 0 to 10 inclusive using the variable 'contador'
while (contador <= 10)
{
    // Print the multiplication of 'numero' by 'contador' in a formatted string
    Console.WriteLine($"{contador}º  Execuções {numero} * {contador} = {numero * contador}");
     // se não colocar o contador no while o programa entra em loop infinito
    contador++;
}
