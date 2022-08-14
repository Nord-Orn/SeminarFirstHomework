//Задача 19. Напишите программу, которая принимает на вход пятизначное число 
//и проверяет, является ли оно палиндромом.
//
Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
int numberA = 0;
int revers = 0;
int remains = 0;
int numberB =0;
if (number > 0)
{
    while (number > 99999 || number < 10000)
    {
        Console.WriteLine("Ошибка. Введите пятизначное число");
        number = Convert.ToInt32(Console.ReadLine());
    }
    numberA = number % 100;
    while (number > 0)
    {
        remains = number % 10;
        revers = (revers * 10) + remains;
        number = number / 10;
    }
    numberB = revers % 100;
    if (numberA == numberB)
    {
        Console.Write("Палиндром.");
    }
    else
    {
        Console.WriteLine("Не палиндром.");
    }
}
else if (number < 0)
{
    while (number < -99999 || number > -10000)
    {
        Console.WriteLine("Ошибка. Введите пятизначное число");
        number = Convert.ToInt32(Console.ReadLine());
    }
    numberA = number % 100;
    while (number < 0)
    {
        remains = number % 10;
        revers = (revers * 10) - remains;
        number = number / 10;
    }
    numberB = revers % 100*-1;
    if (numberA == numberB)
    {
        Console.WriteLine("Палиндром.");
    }
    else
    {
        Console.WriteLine("Не палиндром.");
    }
}
