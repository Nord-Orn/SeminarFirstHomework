// Задача 13: Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.
Console.Write("Ведите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int Revers = 0;
if (number >= 0)
{
    while (number > 0)
    {
        int A = number % 10;
        Revers = (Revers * 10) + A;
        number = number / 10;
    }
    Revers = Revers / 100 % 10;
    if (Revers == 0)
    {
        Console.WriteLine("Третьей цифры нет");
    }
    else
    {
        Console.WriteLine($"Третья  цифра числа = {Revers}");
    }
}
else if (number < 0)
{
    while (number < 0)
    {
        int A = number % 10;
        Revers = (Revers * 10) - A;
        number = number / 10;
    }
    Revers = Revers / 100 % 10;
    if (Revers == 0)
    {
        Console.WriteLine("Третьей цифры нет");
    }
    else
    {
        Console.WriteLine($"Третья  цифра числа = {Revers}");
    }
}


