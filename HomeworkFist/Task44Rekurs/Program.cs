// Задача 44: Используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
//Если N = 5 -> 0 1 1 2 3
//Если N = 3 -> 0 1 1
//Если N = 7 -> 0 1 1 2 3 5 8
double Febonachi(int N)
{
    if (N ==0 || N == 1) return 0;
    else if (N == 2 || N == 3) return 1;
    else return Febonachi(N - 2) + Febonachi(N - 1);
}

Console.Clear();
Console.Write("Введите число Фибоначи: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine($"Фибоначчи {N} = {Febonachi(N)}: ");
Console.WriteLine();