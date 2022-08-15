// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
Console.Write("Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень числа А: ");
int B = Convert.ToInt32(Console.ReadLine());
double number = A;
for (int i = 1; i < B; i++)
{
    number = number * A;
}
Console.WriteLine($"Число {A} в степени {B} = {number}");
Console.WriteLine();