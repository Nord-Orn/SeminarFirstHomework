// Задача 45: Напишите программу, которая будет создавать 
//копию заданного массива с помощью поэлементного копирования.
Console.Clear();
Console.Write("Введите размерность исходного массива: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[] array = new int[N];
int[] copy = new int[array.Length];
for (int i = 0; i < N; i++)
{
    array[i] = new Random().Next(-100, 101);
    copy[i] = array[i];
}
Console.WriteLine("Исхожный массив: [" + string.Join(", ", array) + "]");
Console.WriteLine();
Console.WriteLine("Скопированный массив: [" + string.Join(", ", copy) + "]");
Console.WriteLine();