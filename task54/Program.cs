/*Задача 54: Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию
элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

int[,] CreateArr(int n, int m) //где m- колчичество строк, а n - количество столбов
{
    int[,] arr = new int[n, m];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
            Console.Write($"{arr[i, j]}  ");
        }
        Console.WriteLine();
    }
    return arr;
}
Console.WriteLine("Введите количество строк");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int b = Convert.ToInt32(Console.ReadLine());

void SortToMin(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int numIndex = j;
            for (int k = j + 1; k < array.GetLength(1); k++)
            {


                if (array[i, k] < array[i, numIndex]) numIndex = k;
                

            }
            int help = array[i, j];
            array[i, j] = array[i, numIndex];
            array[i, numIndex] = help;
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    } 
}

int[,] arr = CreateArr(a,b);
        Console.WriteLine();
SortToMin(arr);