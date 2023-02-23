// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.Clear();
string Numbers (int N)
{
    if (N == 1) return $"{N}";
    return Numbers (N -1) + $", {N}";
}
Console.Write("Enter number: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine(Numbers(N));