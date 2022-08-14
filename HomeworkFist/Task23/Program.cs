// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов
Console.Write("Ведите последнее число таблицы: ");
double N = Convert.ToDouble(Console.ReadLine());
Console.Write("Ведите интересующую степень: ");
double A = Convert.ToDouble(Console.ReadLine());
double count = 0;
double step = 0;
while (count <= N)
{
    step = Convert.ToDouble(Math.Pow(count, A));
    Console.WriteLine($"Число = {count} в степени {A} = {step}");
    count++;
}

