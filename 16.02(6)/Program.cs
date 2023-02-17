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

int[,] array2D = GetArray(4, 4, -10, 10);
PrintArray(array2D);

Console.Write("Введите номер строки массива: ");
int i = int.Parse(Console.ReadLine()!);
Console.Write("Введите номер столбца массива: ");
int j = int.Parse(Console.ReadLine()!);

if (i > 0 && i < array2D.GetLength(0) && j > 0 && i < array2D.GetLength(1))
{
    Console.WriteLine($"Элемент = {array2D[i - 1, j - 1]}"!);
}
else
{
    Console.WriteLine($"Элемент в массиве не существует"!);
}