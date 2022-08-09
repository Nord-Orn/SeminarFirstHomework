// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите необходимое колличество случайных чисел для сравнения");
Console.Write("Колличество чисел для сравнения: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 0;
int max = -1000;
while (count < N)
{
    int number = new Random().Next(-1000, 1000);
    Console.Write("число: ");
    Console.WriteLine(number);
    if (max < number)
    {
        max = number;
    } 
    count++;
}
Console.Write("Максимальное число из выборки: ");
Console.WriteLine(max);