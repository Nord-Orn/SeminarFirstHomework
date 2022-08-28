// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
Console.Clear();
Console.Write("Введите необходимое колличество чисел: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[] number = new int[M];
int count = 0;
for (int i = 0; i < M; i++)
{
    number[i] = new Random().Next(-10, 11);
    if (number[i] > 0)
    {
        count++;
    }
} 
Console.WriteLine("Числа: " + string.Join(", ", number));
Console.WriteLine();
Console.WriteLine($"Положительных чисел: {count}");
Console.WriteLine();
