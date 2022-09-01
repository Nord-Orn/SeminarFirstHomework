// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
double[,] array = new double[3, 4];
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        array[i, j] = new Random().Next(-10, 11);
        Console.Write($" {array[i, j]} |");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.Write("Среднее арифметическое по столбцам: ");
double A = (array[0, 0] + array[1, 0] + array[2, 0]) / 3;
Console.Write(" " + Math.Round (A, 2) + " |");
double B = (array[0, 1] + array[1, 1] + array[2, 1]) / 3;
Console.Write(" " + Math.Round (B, 2) + " |");    
double C = (array[0, 2] + array[1, 2] + array[2, 2]) / 3;
Console.Write(" " + Math.Round (C, 2) + " |");
double D = (array[0, 3] + array[1, 3] + array[2, 3]) / 3;
Console.WriteLine(" " + Math.Round (D, 2) + " |");