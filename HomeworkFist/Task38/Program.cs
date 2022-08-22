// Задача 38: Задайте с клавиатуры массив вещественных (double) чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
Console.Clear();
Console.WriteLine("Введите размерность Массива");
int N = Convert.ToInt32(Console.ReadLine());
double[] array = new double[N];
double min = 0;
double max = 0;
double raz = 0;
for (int i = 0; i < N; i++)
{
    array[i] = new Random().Next(-100, 100);
    if (array[i] > max)
    {
        max = array[i];
    }
    else if (array[i] < min)
    {
        min = array[i];
    }
}
raz = max - min;
Console.WriteLine("Массив: [" + string.Join(", ", array) + "]");
Console.WriteLine();
Console.WriteLine($"Разница между min и max элементами массива = {raz}");
Console.WriteLine();