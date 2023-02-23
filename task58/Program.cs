// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Это возможно при соблюдении условия: кол-во столбцов матр1 = кол-во строк матр2 !!!

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

int[,] MultiplMatrix(int[,] array1, int[,] array2)
{
    int[,] arrayMultipl = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < arrayMultipl.GetLength(0); i++)
    {
        for (int j = 0; j < arrayMultipl.GetLength(1); j++)
        {
            arrayMultipl[i, j] = array1[i, j] * array2[i, j] + array1[i, j + 1] * array2[i + 1, j];
            // i++;
            // j++;
        }
    }
    return arrayMultipl;
}

int[,] FirstArray = GetArray(2, 2, 1, 10);
PrintArray(FirstArray);
Console.WriteLine();
int[,] SecondArray = GetArray(2, 2, 1, 10);
PrintArray(SecondArray);
Console.WriteLine();


int[,] FinalArray = MultiplMatrix(FirstArray, SecondArray);
PrintArray(FinalArray);