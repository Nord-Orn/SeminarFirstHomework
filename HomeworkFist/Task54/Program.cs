// Задача 54: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2
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

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {            
            Console.Write($"{arr[i, j]} |");
        }
        Console.WriteLine();
    }
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
for (int i = 0; i < Array.GetLength(0); i++)
{
    for (int j = 0; j < Array.GetLength(1) - 1; j++)
   {
        for (int z = 0; z < Array.GetLength(1) - 1; z++)
        {
            if (Array[i, z] < Array[i, z + 1])
            {
                int A = Array[i, z];
                Array[i, z] = Array[i, z + 1];
                Array[i, z + 1] = A;
            }
        }
    }
}
Console.WriteLine("Массив отредактированный:");
PrintArray(Array);
Console.WriteLine();
