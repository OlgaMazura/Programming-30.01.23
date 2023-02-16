// See Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.Clear();

double[,] GetDoubleArray(int m, int n, double MinValue, double MaxValue)
{
    double[,] Result = new double[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Result[i, j] = new Random().NextDouble() * (MaxValue - MinValue) + MinValue;
        }
    }
    return Result;
}

void PrintArray(double[,] NewArray)
{
    for (int i = 0; i < NewArray.GetLength(0); i++)
    {
        for (int j = 0; j < NewArray.GetLength(1); j++)
        {
            Console.Write($"{NewArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

double[,] array2D = GetDoubleArray(3, 3, 1, 10);
PrintArray(array2D);