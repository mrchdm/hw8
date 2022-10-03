/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

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

int[,,] CreateCubeRandom(int strings, int columns, int depth, int min, int max)
{
    int[,,] array = new int[strings, columns, depth];
    int[] repeats = new int[strings * columns * depth];
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2);)
            {
                int newNum = new Random().Next(min, max + 1);
                if (newNum < 10) newNum *= 10; //проверка на двузначное число
                else if (newNum > 100) newNum /= 10;
                repeats[count] = newNum;
                bool checkRepeat = true;
                for (int l = 0; l < count; l++)
                {
                    if (newNum == repeats[l])
                    {
                        checkRepeat = false;
                        repeats[count] = 0;
                        break;
                    }
                }
                if (checkRepeat)
                {
                    array[i, j, k] = newNum;
                    PrintText($"{array[i, j, k]} ({i},{j},{k}) ");
                    count++;
                    k++;
                }
            }
            NewLine();
        }
    }
    return array;
}

PrintText("Введите количество строк, столбцов и глубину массива: ");
NewLine();
int row = UserEnter();
int col = UserEnter();
int depth = UserEnter();

PrintText("Введите минимальное случайное число, а затем максимальное: ");
NewLine();
int min = UserEnter();
int max = UserEnter();

int[,,] numbers = CreateCubeRandom(row, col, depth, min, max);