// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
Console.Clear();

int[] GetArray(int size, int MinValue, int MaxValue)
{
    int[] Result = new int[size];

    for (int i = 0; i < size; i++)
    {
        Result[i] = new Random().Next(MinValue, MaxValue + 1);
    }
    return Result;
}
int CountElements(int[] array)
{
    int Count = 0;
    foreach (int i in array)
    {
        if (i % 2 == 0)
        {
            Count++;
        }
    }
    return Count;
}

int[] array = GetArray(10, 100, 999);
Console.WriteLine(string.Join(",", array));
int N = CountElements(array);
Console.WriteLine($"Amount of even numbers is {N}");