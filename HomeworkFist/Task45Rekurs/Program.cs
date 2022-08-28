// Дополнительная задача на рекурсию
//Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N. (использовать рекурсию)
//4 -> 24
//5 -> 120
double Factorial(int N)
{
    //if (N == 0) return 1; нарушает рекурсию, вписываем в условие.
    if (N == 1) return 1;
    else return N * Factorial(N-1);
}

Console.Write("Введите факториал: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N==0) Console.WriteLine($"{N}! = 1");
else Console.WriteLine($"{N}! = {Factorial(N)}");