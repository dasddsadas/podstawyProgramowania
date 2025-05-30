//task 9

//sprawdza czy podane liczby sa w podanym zakresie

int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());

bool isInRange1 = num1 < 100 && num2 > 200;
bool isInRange2 = num2 < 100 && num1 > 200;
if ((isInRange1) || (isInRange2))
{
    Console.WriteLine("liczby są w podanym zakresie");
}
else
{
    Console.WriteLine("liczby nie są w podanym zakresie");
}