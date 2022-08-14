// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов
Console.Write("Ведите последнее число таблицы: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите интересующую степень: ");
int A = Convert.ToInt32(Console.ReadLine());
int count = 0;
double step = 0;
while (count <= N)
{
    step = Convert.ToDouble(Math.Pow(count, A));
    Console.WriteLine($"Число = {count} в степени {A} = {step}");
    count++;
}

