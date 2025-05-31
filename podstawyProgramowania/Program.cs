int number = int.Parse(Console.ReadLine());

bool InRange20Of100 = number >= 80 && number <= 120;
bool inRange20Of200 = number >= 180 && number <= 220;
if ((InRange20Of100) || (inRange20Of200))
{
    Console.WriteLine("liczba jest wieksza lub mniejsza od 100 lub 200 o 20");
}
else
{
    Console.WriteLine("liczba nie jest wieksza lub mniejsza od 100 lub 200 o 20");
}