// Задача 8: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите переменную N для нахождения четных чисел от 1 до N: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N < 0)
{
    int count = 0;
    while (count >= N)
    {
        if (count % 2 == 0)
        {
            Console.Write("четное: ");
            Console.WriteLine(count);
        }
        count--;
    }
}
else
{
    int count = 2;
    while (count <= N)
    {
        Console.Write("четное: ");
        Console.WriteLine(count);
        count = count + 2;
    }
    if (N == 1)
    {
        Console.Write("Четных чисел нет");
    }
    if (N == 0)
    {
        Console.Write("четное: 0");
    }
}
