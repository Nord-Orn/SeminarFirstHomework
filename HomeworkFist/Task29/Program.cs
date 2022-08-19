// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int[] arrey(int number, int min, int max)
{
    int[] arr = new int[number];
    for (int i = 0; i < number; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
    return arr;
}

Console.Clear();
Console.WriteLine("Введите колличество элементов массива");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элементов массива");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элементов массива");
int max = Convert.ToInt32(Console.ReadLine());
while (max <= min)
{
    Console.WriteLine("Ошибка. Введите число больше минимального");
    max = Convert.ToInt32(Console.ReadLine());
}
Console.Write("Массив: ");
Console.WriteLine(string.Join(", ", arrey(number, min, max)));
Console.WriteLine();