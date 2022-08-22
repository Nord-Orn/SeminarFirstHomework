// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
//значения которых лежат в отрезке [10,99].
//Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
//[5, 18, 123, 6, 2] -> 1
//[1, 2, 3, 6, 2] -> 0
//[10, 11, 12, 13, 14] -> 5
Console.Clear();
Console.WriteLine("Введите количество элементов массива");
int N = Convert.ToInt32(Console.ReadLine());
int count = 0;
int[] array = new int[N];
for (int i = 0; i < N; i++)
{
    array[i] = new Random().Next(0, 1000);

    if (array[i] >10 && array[i] < 99)
    {
        count++;
    }
}
Console.WriteLine("Массив [" + string.Join(", ", array) + "]");
Console.WriteLine();
Console.WriteLine($"Колличество элементов в отрезке от 10 до 99: {count}");
Console.WriteLine();