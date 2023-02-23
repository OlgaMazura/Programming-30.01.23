// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8" 

Console.Clear();
string Numbers (int M, int N)
{
    if (M == N) return $"{M}";
    return $"{M}, " + Numbers (M + 1, N);
}
Console.Write("Enter number 1: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Enter number 2: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine(Numbers(M, N));
