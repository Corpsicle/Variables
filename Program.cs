// See https://aka.ms/new-console-template for more information
Console.Title = "Variables";

char letter; letter = 'A';      // Declared then Initialized.
int number; number = 100;       // Declared then Initialized.
float body = 98.6f;             // Declared and Initialized.
double pi = 3.14159;            // Declared and Initialized.
decimal sum = 1000.00m;         // Declared and Initialized.
bool flag = false;              // Declared and Initialized.
string text = "C# is fun!";     // Declared and Initialized.

Console.WriteLine($"Char letter\t = {letter}");
Console.WriteLine($"Int number\t = {number}");
Console.WriteLine($"Float body\t = {body}");
Console.WriteLine($"Double pi\t = {pi}");
Console.WriteLine($"Decimal sum\t = {sum}");
Console.WriteLine($"Boolean flag\t = {flag}");
Console.WriteLine($"String text\t = {text}");
Console.WriteLine();