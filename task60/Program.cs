// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

Console.Clear();
int[,,] GetArray(int x, int y, int z, int minValue, int maxValue)
{
    int[,,] array = new int[x, y, z];
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                array[i, j, k] = new Random().Next(minValue, maxValue + 1);
            }
        }
    }
    return array;
}

void PrintArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                Console.Write($"{inArray[i, j, k]} ({i}, {j}, {k}) \t");
            }
        }
    }
}
int[,,] Array = GetArray(2, 2, 2, 10, 100);
PrintArray(Array);
Console.WriteLine();