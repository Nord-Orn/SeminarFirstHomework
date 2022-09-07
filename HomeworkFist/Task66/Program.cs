// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
//сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
Console.Clear();
Console.Write("Введите M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());
PrintSumm(M, N);

void PrintSumm(int M, int N)
{
    int sum = 0;
    if (M > N)
    {
        for (int i = N; i <= M; i++)
        {
            sum = sum + i;

        }
        Console.WriteLine($"Сумма элементов= {sum} ");
    }
    else
    {
        for (int i = M; i <= N; i++)
        {
            sum = sum + i;
        }
        Console.WriteLine($"Сумма элементов= {sum} ");
    }
    Console.WriteLine();
}
