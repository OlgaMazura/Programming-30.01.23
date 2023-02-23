// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Clear();

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

void FindElement(int[,] array) 
{
    Console.Write("Enter line: ");
    int row = int.Parse(Console.ReadLine()!); 
    Console.Write("Enter column: ");
    int column = int.Parse(Console.ReadLine())!; 

    if (row < 0 | row > array.GetLength(0) | column < 0 | column > array.GetLength(1))
    {
        Console.WriteLine("There is no such element");
    }
    else
    { 
        Console.WriteLine($"Element = {array[row - 1, column - 1]}");
    }
}

int[,] array2D = GetArray(2, 2, 1, 10);
PrintArray(array2D);
FindElement(array2D);