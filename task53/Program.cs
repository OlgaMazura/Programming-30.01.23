// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

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

void SwapTwoRow(int[,] arrayNew)
{
    for (int j = 0; j < arrayNew.GetLength(1); j++)
    {
        int temp = arrayNew[0, j];
        arrayNew[0, j] = arrayNew[arrayNew.GetLength(0) - 1, j];
        arrayNew[arrayNew.GetLength(0) - 1, j] = temp;
    }

}

int[,] array2d = GetArray(4, 4, 1, 9);
PrintArray(array2d);
Console.WriteLine();

SwapTwoRow(array2d);
PrintArray(array2d);