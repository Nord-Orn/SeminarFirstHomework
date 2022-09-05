// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)

void ArrayRandom(int[,,] Arr)
{
    Random rand = new Random();
    int size = Arr.GetLength(0) * Arr.GetLength(1) * Arr.GetLength(2);
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(10, 100);
        if (i>=1)
        {
            for (int j = 0; j < i; j++)
            {
                while (arr[i] == arr[j])
                {
                    arr[i] = rand.Next(10, 100);
                    j = 0;                   
                }                
            }
        }
    }    
    int count = 0;    
    for (int i = 0; i < Arr.GetLength(0); i++)
    {
        for (int j = 0; j < Arr.GetLength(1); j++)
        {
            //Console.WriteLine();
            for (int m = 0; m < Arr.GetLength(2); m++)
            {
                Arr[i, j, m] = arr[count];
                count++;
                Console.Write($"{Arr[i, j, m]} - ({i},{j},{m})|");
            } 
            Console.WriteLine();         
        }
        Console.WriteLine();
    }    
}

 
Console.Clear();
Console.Write("Введите высоту массива: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите ширину массива: ");
int S = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите глубину массива: ");
int F = Convert.ToInt32(Console.ReadLine());
int[,,] Array = new int[N, S, F];
Console.WriteLine();
Console.WriteLine("Массив:");
ArrayRandom(Array);
