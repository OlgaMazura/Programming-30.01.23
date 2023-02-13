// Задача 44. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

Console.Clear();
int[] arrayFib(int N)
{
    int[] array = new int[N];
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i<array.Length; i++)
    {
        array[i] = array[i-1]+array[i-2];
    }
    return array;
}

Console.Write("Enter your Number: ");
int nFib = int.Parse(Console.ReadLine()!);
Console.Write(string.Join(", ", arrayFib(nFib)));


