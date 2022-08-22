// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0
Console.Clear();
Console.WriteLine("Ведите размерность массива");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
int sum = 0;
for (int i = 0; i < N; i++)
{
    array[i] = new Random().Next(-100, 101);
    if (i % 2 == 1)
    {
        sum = sum + array[i];
    }
}
Console.WriteLine("Массив: [" + string.Join(", ", array) + "]");
Console.WriteLine();
Console.WriteLine($"Сумма элементов = {sum}");
Console.WriteLine();
