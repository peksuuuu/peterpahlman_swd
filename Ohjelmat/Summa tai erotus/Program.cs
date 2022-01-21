Console.WriteLine("Syötä luvut");
var number = Console.ReadLine();
int a = int.Parse(number);

var number2 = Console.ReadLine();
int b = int.Parse(number2);

Console.WriteLine("Press 1 for Summa or 2 for Erotus.");
int laskutoimitus;

if (int.TryParse(Console.ReadLine(), out laskutoimitus))
{
    if
        (laskutoimitus == 1)
        Console.WriteLine(a + b);

    else if
        (laskutoimitus == 2)
        Console.WriteLine(a - b);

    else
        Console.WriteLine("Wrong input");
}

Console.ReadLine();