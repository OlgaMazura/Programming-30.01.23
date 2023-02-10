// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
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
int SumElements(int[] array)
{
    int Sum = 0;
    for (int i = 0; array[i] %2 != 0;) 
    {
        Sum += i;
    //     if (array[i] % 2 != 0)
    //     {
    //         Sum = Sum + i;
    //     }
    }
    return Sum;
}

int[] array = GetArray(5, 1, 10);
Console.WriteLine(string.Join(",", array));
int N = SumElements(array);
Console.WriteLine($"Summ of odd elements is {N}");
