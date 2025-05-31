//task 6

//mnozenie liczby przez wszystko od 1 do 10

int num1 = int.Parse(Console.ReadLine());
int num2;

for (num2 = 1; num2 <= 10; num2++)
{
    Console.WriteLine(num1 + " x " + num2 + " = " + (num1 * num2));
}