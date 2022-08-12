// Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите день недели: ");
int day = Convert.ToInt32(Console.ReadLine());
while (day < 1 || day > 7)
{
    Console.WriteLine("Число введено неверно. Ведите от 1 до 7");
   day = Convert.ToInt32(Console.ReadLine());
}
switch(day)
{	
    case 1:	
        Console.WriteLine("Понедельник -рабочий день.");
        break;
    case 2:
        Console.WriteLine("Вторник -рабочий день.");
        break;
    case 3:
        Console.WriteLine("Среда -рабочий день.");
        break;
    case 4:
        Console.WriteLine("Четверг -рабочий день.");
        break;
    case 5:
        Console.WriteLine("Пятница -рабочий день.");
        break;
    case 6:
        Console.WriteLine("Суббота -выходной день! Ура!!!");
        break;
    case 7:
        Console.WriteLine("Воскресенье-выходной день! Ура!!!");
        break;
}
