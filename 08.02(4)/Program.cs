// Напишите программу, которая выводит массив из 8ми элементов, заполненный 0 и 1 в случайном порядке
// [1, 0, 0, 0, 0, 1, 1, 0]

Console.Clear();
int[] GetArray()
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
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