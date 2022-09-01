// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном 
//массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет


Console.Clear();
Console.Write("Введите колличество строк ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов ");
int B = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите число от 0 до 50 которое нужно найти в массиве ");
int S = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[N, B];
Random rand = new Random();
int count = 0;
for (int i = 0; i < N; i++)
{
    for (int j = 0; j < B; j++)
    {
        array[i, j] = rand.Next(0, 50);
        Console.Write($" {array[i, j]} |");
        if (array[i, j] == S) count = 1;
    }
    Console.WriteLine();
}
Console.WriteLine();
if (count == 1) Console.WriteLine($"Число {S} есть в массиве");
else Console.WriteLine($"Числа {S} нет в массиве");
Console.WriteLine();