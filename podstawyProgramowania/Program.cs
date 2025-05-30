//task 10

//sprawdza czy liczba jest w odleglosci 20 od 100 albo 200

int num1 = int.Parse(Console.ReadLine());

bool inRange100 = num1 >= 80 && num1 <= 120;
bool inRange200 = num1 >= 180 && num1 <= 220;
if ((inRange100) || (inRange200))
{
    Console.WriteLine("liczba jest wieksza lub mniejsza od 100 lub 200 o 20");
}
else
{
    Console.WriteLine("liczba nie jest wieksza lub mniejsza od 100 lub 200 o 20");
}