// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.Clear();
int[,] GetArray(int row, int col, int minValue, int maxValue)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void SortFromMaxToMin (int[,] NewArray)
{
    for (int i = 0; i < NewArray.GetLength(0); i++)
    {
        for (int j = 0; j < NewArray.GetLength(1); j++)
        {
            for (int k = 0; k < NewArray.GetLength(1) - 1; k++)
            {
                if (NewArray[i, k] < NewArray[i, k + 1])
                {
                    int temp = NewArray[i, k + 1];
                    NewArray[i, k + 1] = NewArray[i, k];
                    NewArray[i, k] = temp;
                }
            }
        }
    }
}

int[,] array2d = GetArray(4, 4, 1, 9);
PrintArray(array2d);
Console.WriteLine();
SortFromMaxToMin(array2d);
PrintArray(array2d);