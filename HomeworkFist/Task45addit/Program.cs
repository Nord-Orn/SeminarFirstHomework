// Дополнительная задача на рекурсию
//Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N. (использовать рекурсию)
//4 -> 24
//5 -> 120
Console.Clear();
Console.Write("Введите факториал: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N == 0)
{
    Console.WriteLine($"{N}! = 1");
}
else
{
    double number = 1;
    for (int i = 1; i < N + 1; i++)
    {
        number = number * i;
    }
    Console.WriteLine($"{N}! = {number}");
    Console.WriteLine();
}

