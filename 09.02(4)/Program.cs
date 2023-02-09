// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

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
        if (i > 10 && i < 99)
        {
            Count++;
        }
    }
    return Count;
}

int[] array = GetArray(123, -9, 150);
Console.WriteLine(string.Join(",", array));
int N = CountElements(array);
Console.WriteLine($"Amount of numbers between 10 and 100 is {N}");