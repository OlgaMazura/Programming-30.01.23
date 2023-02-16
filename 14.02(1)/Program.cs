// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.Clear();

Console.Write("Enter numbers separated by space: ");
int [] NewArray = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

int CountPositiveElements(int[] NewArray)
{
    int Count = 0;
    for (int i = 0; i < NewArray.Length; i++)
    {
      if (NewArray[i] > 0)
      {
        Count++;
      }  
    }
    return Count;
}

Console.WriteLine($"There are {CountPositiveElements(NewArray)} positive numbers"!);