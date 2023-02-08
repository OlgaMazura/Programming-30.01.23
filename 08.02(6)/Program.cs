// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();
int[] GetArray()
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next();
    }
    return array;
}
void printArray(int[] NewArray)
{
    for (int i = 0; i < NewArray.Length; i++)
        Console.Write($"{NewArray[i]} "!); 
}
int[] array = GetArray();
printArray(array);