// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
void PrintArrayRandom(int[,] Arr)
{
    for (int i = 0; i < Arr.GetLength(0); i++)
    {
        for (int j = 0; j < Arr.GetLength(1); j++)
        {
            Arr[i, j] = new Random().Next(1, 10);
            Console.Write($"{Arr[i, j]} |");
        }
        Console.WriteLine();
    }
}

int SumLine(int[,] Array, int i)
{
    int sum = Array[i, 0];
    for (int j = 1; j < Array.GetLength(1); j++)
    {
        sum = sum + Array[i, j];
    }
    return sum;
}

Console.Clear();
Console.Write("Введите колличество строк массива: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов массива: ");
int S = Convert.ToInt32(Console.ReadLine());
int[,] Array = new int[N, S];
Console.WriteLine();
Console.WriteLine("Исходный массив:");
PrintArrayRandom(Array);
Console.WriteLine();
int sum = SumLine(Array, 0);
int min = 1;
for (int i = 1; i < Array.GetLength(0); i++)
{
    int temp = SumLine(Array, i);
    if (sum > temp)
    {
        sum = temp;
        min = i + 1;
    }
}

Console.WriteLine($"Cтрокa {min} с наименьшей суммой = {sum}");
Console.WriteLine();
