// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.Clear();

Console.Write("How many numbers do you want to enter? - ");
int size = int.Parse(Console.ReadLine()!);
Console.Write("Enter numbers separated by space - ");
String[] NewArray = Console.ReadLine().Split();
Console.WriteLine(String.Join(", ", NewArray));

int CountPositiveElements(int[] NewArray)
{
    int Count = 0;
    foreach (int i in NewArray)
    {
      if (i > 0)
      {
        Count++;
      }  
    }
    return Count;
}

int N = CountPositiveElements(NewArray);
Console.WriteLine($"There are {N} positive numbers"!);