//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.Clear();
Console.Write("Введите значение b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
double X = (b1 - b2) / (k2 - k1);
double y1 = k1 * X + b1;
double y2 = k2 * X + b2;
Console.WriteLine($"Точка пересечения 1 прямая: у = {y1} х = {X}");
Console.WriteLine($"Точка пересечения 2 прямая: у = {y2} х = {X}");
Console.WriteLine();
