// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Clear();

int SumDigit(int N)
{
    if (N == 0) return 0;
    return N % 10 + SumDigit(N / 10);
}

Console.WriteLine($"Enter any number: "!);
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine(SumDigit(N));

