// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int Sum(int A)
{
    int sum = 0;
    for (; A > 0; A = A / 10)
    {
        int ost = A % 10;
        sum = sum + ost;
    }
    return sum;
}

Console.WriteLine();
Console.Write("Ведите число: ");
int A = Convert.ToInt32(Console.ReadLine());
if (A > 0)
{
    Console.WriteLine($"Сумма цифр в числе = {Sum(A)}");
    Console.WriteLine();
}
else
{
    A = A * -1;
    Console.WriteLine($"Сумма цифр в числе = {Sum(A)}");
    Console.WriteLine();
}