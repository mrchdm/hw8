/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

void PrintText(string text)
{
    Console.Write(text);
}

void NewLine()
{
    Console.WriteLine();
}

void EndOnPC()
{
    Console.Read();
}


dynamic UserEnter()
{
    string a = Console.ReadLine();
    if (a != "")
    {
        if (int.TryParse(a, out int n))
        {
            int b = Convert.ToInt32(a);
            return b;
        }
        else if (a == "y") return true;
        else if (a == "n") return false;
        else return a;
    }
    else
    {
        a = "exit";
        return a;
    }
}

void PrintArrayMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        NewLine();
    }
    NewLine();
}

int[,] FillMatrixSpiral(int height, int width, int first)
{
    int[,] array = new int[height, width];
    array[0, 0] = first;
    int i = 0, j = 0, circle = 0, action = 0, count = new int();
    if (width >= height) count = height * 2 - 1;
    else count = width * 2;
    while (count != 0)
    {
        if (action == 0)
        {
            j++;
            array[i, j] = array[i, j - 1] + 1;
            if (j == width - 1 - circle)
            {
                action++;
                count--;
            }
        }
        else if (action == 1)
        {
            i++;
            array[i, j] = array[i - 1, j] + 1;
            if (i == height - 1 - circle)
            {
                action++;
                count--;
            }
        }
        else if (action == 2)
        {
            j--;
            array[i, j] = array[i, j + 1] + 1;
            if (j == 0 + circle)
            {
                circle++;
                action++;
                count--;
            }
        }
        else if (action == 3)
        {
            i--;
            array[i, j] = array[i + 1, j] + 1;
            if (i == 0 + circle)
            {
                action = 0;
                count--;
            }
        }
    }
    return array;
}

PrintText("Введите высоту и ширину прямоугольника: ");
NewLine();
int height = UserEnter();
int width = UserEnter();
PrintText("Введите первое число: ");
NewLine();
int first = UserEnter();

int[,] square = FillMatrixSpiral(height, width, first);
PrintArrayMatrix(square);

EndOnPC();
