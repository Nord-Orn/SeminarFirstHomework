// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

void Numbers(double[,] num)
{
    Random rand = new Random();
    for (int i = 0; i < num.GetLength(0); i++)
    {
        for (int j = 0; j < num.GetLength(1); j++)
        {
            int N = rand.Next(0, 2);
            if (N == 0)
            {
                num[i, j] = rand.NextDouble() * 10;
                Console.Write(" " + Math.Round(num[i, j], 1) + " |");
            }
            if (N == 1)
            {
                num[i, j] = rand.NextDouble() * -10;
                Console.Write(" " + Math.Round(num[i, j], 1) + " |");
            }

        }
        Console.WriteLine();
    }
}


Console.Clear();
Console.Write("Введите колличество строк ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов ");
int j = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[i, j];
Numbers(array);
Console.WriteLine();