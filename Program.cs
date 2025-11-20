using System.Globalization;

// See https://aka.ms/new-console-template for more information
Console.Title = "Variables";

// Combined declaration + initialization; use const for real constants.
var letter = 'A';
var number = 100;
var body = 98.6f;
const double Pi = 3.14159;
var sum = 1000.00m;
var flag = false;
var text = "C# is fun!";

// Pack labels, values and optional format into a tuple array and print in a loop.
// Alignment ensures clean columns; InvariantCulture ensures consistent decimal separators.
var values = new (string Label, object Value, string Format)[]
{
    ("Char letter", letter, ""),
    ("Int number", number, ""),
    ("Float body", body, "F1"),
    ("Double pi", Pi, "F5"),
    ("Decimal sum", sum, "F2"),
    ("Boolean flag", flag, ""),
    ("String text", text, "")
};

foreach (var (label, value, format) in values)
{
    string output = value is IFormattable fmt && !string.IsNullOrEmpty(format)
        ? fmt.ToString(format, CultureInfo.InvariantCulture)
        : value?.ToString() ?? string.Empty;

    Console.WriteLine($"{label,-15} = {output}");
}

Console.WriteLine();