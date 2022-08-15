// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine();
Console.Write("Ведите число: ");
int A = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int number = 0;
if (A > 0)
{
    for (; A > 0; A = A / 10)
    {
        number = A % 10;
        sum = sum + number;
    }
    Console.WriteLine($"Сумма цифр в числе = {sum}");
    Console.WriteLine();
}
else
{
    for (; A < 0; A = A / 10)
    {
        number = A % 10;
        sum = sum + number * -1;
    }
    Console.WriteLine($"Сумма цифр в числе = {sum}");
    Console.WriteLine();
}