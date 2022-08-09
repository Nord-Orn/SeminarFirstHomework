//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.
Console.WriteLine("Ведите для сравнения два числа.");
Console.Write("Число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA == numberB)
{
    Console.WriteLine("числа А и В равны");
}
else
{
    if (numberA > numberB)
    {
        Console.WriteLine("число А больше числа В");
    } 
    else
    {
        Console.WriteLine("число B больше числа A");
    }
}