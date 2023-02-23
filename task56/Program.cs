// Задача 56: Задайте прямоугольный двумерный массив. Напишите 
// программу, которая будет находить строку с наименьшей суммой элементов.

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

void FindSum(int[,] array)
{
    int Row = 0;
    int MinSumRow = 0;
    int Sum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        Row += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) Sum += array[i, j];
        if (Sum < Row)
        {
            Row = Sum;
            MinSumRow = i;
        }
        Sum = 0;
    }
    Console.Write($"Наименьшая сумма элементов находится в {MinSumRow + 1} строке");
}

int[,] array2d = GetArray(4, 4, 1, 3);
PrintArray(array2d);
Console.WriteLine();
FindSum(array2d);
