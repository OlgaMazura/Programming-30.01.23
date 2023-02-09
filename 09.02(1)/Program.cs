//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
//Найдите сумму отрицательных и положительных элементов массива.

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
int[] array = GetArray(12, -9, 9);
Console.WriteLine(String.Join(", ", array));

int PositivSum = 0;
int NegativSum = 0;

foreach (int element in array)
{
    PositivSum += element > 0 ? element : 0;
    // if (element > 0)
    // {
    //     PositivSum += element;
    // }
    NegativSum += element < 0 ? element : 0;
}
Console.WriteLine($"Sum Positiv numbers = {PositivSum}, Sum Negativ numbers = {NegativSum}");