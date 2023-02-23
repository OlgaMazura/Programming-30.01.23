// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.Clear();

// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

int[,] GetFirstArray(int row, int col, int minValue, int maxValue)
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

// int[,] GetSecondArray(int row, int col, int minValue, int maxValue)
// {
//     int[,] array = new int[row, col];
//     for (int k = 0; k < row; k++)
//     {
//         for (int l = 0; l < col; l++)
//         {
//             array[k, l] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return array;
// }

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

int[,] FirstArray = GetFirstArray(2, 2, 1, 10);
PrintArray(FirstArray);
Console.WriteLine();
int[,] SecondArray = GetFirstArray(2, 2, 1, 10);
PrintArray(SecondArray);

int[,] Multiply(int[,] array)
{
    int[,] FinalArray = new int[array.GetLength(1), array.GetLength(0)];
    // int k = 0;
    // int l = 0;
    for (int k = 0; k < array.GetLength(0); k++)
    {
        for (int l = 0; l < array.GetLength(1); l++)
        {
            FinalArray[k, l] = 0;
            FinalArray[k, l] = FirstArray[i, j] * SecondArray[i, j];
        }
    }
    // return Multiply;
}
Console.WriteLine();
int[,] FinalArray = Multiply;
PrintArray(FinalArray);


