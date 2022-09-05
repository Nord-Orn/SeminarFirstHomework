// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18
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

void resultArray(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMartrix.GetLength(1); k++)
            {
                sum = sum + firstMartrix[i, k] * secomdMartrix[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}

Console.Clear();
Console.Write("Введите колличество строк массива: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов массива: ");
int S = Convert.ToInt32(Console.ReadLine());
int[,] Array = new int[N, S];
Console.WriteLine();
Console.WriteLine("Первая матрица:");
PrintArrayRandom(Array);
int[,] matrix = new int[N, S];
Console.WriteLine("Вторая матрица:");
PrintArrayRandom(matrix);
Console.WriteLine("Произведение двух матриц:");
int[,] result = new int[N, S];
resultArray(Array, matrix, result);
for (int i = 0; i < result.GetLength(0); i++)
{
    for (int j = 0; j < result.GetLength(1); j++)
    {
        Console.Write($"{result[i, j]} |");
    }
    Console.WriteLine();
}
Console.WriteLine();
