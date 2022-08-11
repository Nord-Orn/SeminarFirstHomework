// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Ведите 1 для положительных трехзначных чисел или 2 для отрицательных");
int number = Convert.ToInt32(Console.ReadLine());
int numberA = new Random().Next(100, 1000);
int numberB = new Random().Next(-999, -99);
int A = numberA / 10 % 10;
int B = numberB / 10 % 10 *-1;
while (number < 1 || number > 2)
{
    Console.WriteLine("Число введено неверно. Ведите 1 или 2");
    number = Convert.ToInt32(Console.ReadLine());
}
if (number == 1)
{
    Console.WriteLine($"Наше случайное число = {numberA}");
    Console.WriteLine($"Вторая цифра числа = {A}");
}
else if (number == 2)
{
    Console.WriteLine($"Наше случайное число = {numberB}");
    Console.WriteLine($"Вторая цифра числа = {B}");
}

