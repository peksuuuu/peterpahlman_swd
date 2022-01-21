Console.Write("Montako lukua? ");
var a = Console.ReadLine();
var b = int.Parse(a);
double summa = 0, i = 0, n = 0;
Console.WriteLine("Anna luku");

do
{
    n = double.Parse(Console.ReadLine());
    summa += n;
    ++i;
}
while (i < b);

double keskiarvo = summa / b;

Console.WriteLine
    ("Lukujen summa on: " + summa + "\n" +
    "ja keskiarvo on: " + keskiarvo);
Console.ReadLine();