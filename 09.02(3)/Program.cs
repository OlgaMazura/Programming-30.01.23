// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
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
bool FindElement(int Number, int[] Collection)
{
    foreach (int Element in Collection)
    {
        if (Element == Number)
        {
            return true;
        }
    }
    return false;
}
int[] array = GetArray(12, -9, 9);
Console.WriteLine(string.Join(",", array));
Console.Write("Enter number: ");
int N = int.Parse(Console.ReadLine()!);
if (FindElement(N, array))
{
   Console.WriteLine("YES"); 
}
else
{
    Console.WriteLine("NO");
}