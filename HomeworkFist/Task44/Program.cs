// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
//Если N = 5 -> 0 1 1 2 3
//Если N = 3 -> 0 1 1
//Если N = 7 -> 0 1 1 2 3 5 8
Console.Clear();
Console.Write("Введите колличество чисел Фибоначи: ");
int N = Convert.ToInt32(Console.ReadLine());
double[] Fib = new double[N];
Fib[0] = 0;
Fib[1] = 1;
for (int i = 2; i < N; i++)
{
    Fib[i] = Fib[i - 2] + Fib[i - 1];
}
Console.WriteLine("Числа Фибоначи: " + string.Join(", ", Fib));
Console.WriteLine();