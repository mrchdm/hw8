/*Задача 58: Задайте две матрицы. 
Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

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

Console.WriteLine("Введите количество строк для первой матрицы");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов для первой матрицы");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк для второй матрицы");
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов для второй матрицы");
int d = Convert.ToInt32(Console.ReadLine());
int element = 0 ;
int mult =0;
if (b == c)
{
    int[,] array = CreateArr(a, b);
    Console.WriteLine();
    int[,] array2 = CreateArr(c, d);
    Console.WriteLine();
    int[,] array3 = new int[b,c];
    for (int i = 0; i < b; i++)
    {
        for (int j = 0; j < c; j++)
        {
            mult = array[i,j] * array2[j,i];
           //Console.Write($"{array3[i,j]}  ");
           array3[i,j] = array3[i,j] + mult;
           Console.Write($"{array3[i,j] }  ");
        }
        
        Console.WriteLine();
    }
}
else
{
    Console.WriteLine("Операция умножения двух матриц выполнима только в том случае,");
    Console.WriteLine("если число столбцов в первом сомножителе равно числу строк во втором");
}