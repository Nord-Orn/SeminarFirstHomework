// Задача 28*: Напишите программу, в которой задается массив чисел(ввод может быть с клавиатуры, 
//либо можете сами задавать массив чисел) и выдаёт произведение чисел от 1 до N, каждого элемента этого массива.
//{2, 3, 4} -> 2, 6, 24
//{5, 3, 6, 2, 5, 1} -> 6, 720, 2, 120, 1
int[] ArreyA(int N, int min, int max)
{
    int[] arr = new int[N];
    for (int i = 0; i < N; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
    return arr;
}


double[] ArreyB(int[] arrA, int N)
{
    double[] arr = new double[N];
    double cor = 1;
    for (int i = 0; i < N; i++)
    {
        cor = cor * arrA[i];
        arr[i] = cor;
    }
    return arr;
}


double[] ArreyC(int[] arrA, int N)
{
    double[] arr = new double[N];
    for (int i = 0; i < N; i++)
    {
        double cor = 1;
        if (arrA[i] == 0) cor = 0;
        if (arrA[i] < 0)
        {
            for (int j = -1; j >= arrA[i]; j--)
            {
                cor = cor * j;
            }
        }
        else if (arrA[i] > 0)
        {
            for (int j = 1; j <= arrA[i]; j++)
            {
                cor = cor * j;
            }
        }
        arr[i] = cor;
    }
    return arr;
}

Console.Clear();
Console.WriteLine("Введите колличество элементов массива");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента массива");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента массива");
int max = Convert.ToInt32(Console.ReadLine());
while (max <= min)
{
    Console.WriteLine("Ошибка ввода. Ведите число больше минимального значения.");
    max = Convert.ToInt32(Console.ReadLine());
}
int[] arrA = ArreyA(N, min, max);
Console.Write("Массив А: ");
Console.WriteLine("[" + string.Join(", ", (arrA)) + "]");
double[] arrB = ArreyB(arrA, N);
Console.Write("Последовательное произведение элементов Массив А: ");
Console.WriteLine("[" + string.Join(", ", (arrB)) + "]");
double[] arrC = ArreyC(arrA, N);
Console.Write("Произведение каждого элемента Массив А: ");
Console.WriteLine("[" + string.Join(", ", (arrC)) + "]");
Console.WriteLine();
