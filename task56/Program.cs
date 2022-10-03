/*Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке 
и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

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

Console.WriteLine();

Console.WriteLine("Введите количество строк");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк");

 int linenumber = 0;
int minsum = 0;
int[,] array = CreateArr(a, b);
int i = 0;
for (; i < array.GetLength(0)-1; i++)

{
    int nextsum = 0;
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum += array[i, j];
        nextsum += array[i + 1, j];
    }
    if (sum < nextsum)
    {
        minsum = nextsum;
        linenumber = i;
    }
    else
    {
        linenumber = i + 1;
         minsum = sum;
    }
    
}
Console.WriteLine($" наименьшая сумма находится в строке {linenumber}");