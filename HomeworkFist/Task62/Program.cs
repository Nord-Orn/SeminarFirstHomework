// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07
//Console.WriteLine("Hello, World!");

void WriteArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] / 10 <= 0)
                Console.Write($"0{arr[i, j]} ");

            else Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}


Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[n, n];
int temp = 1;
int i = 0;
int j = 0;

while (temp <= n * n)
{
    array[i, j] = temp;
    temp++;
    if (i <= j + 1 && i + j < array.GetLength(1) - 1)
        j++;
    else if (i < j && i + j >= array.GetLength(0) - 1)
        i++;
    else if (i >= j && i + j > array.GetLength(1) - 1)
        j--;
    else
        i--;
}

WriteArray(array);

