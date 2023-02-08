// Напишите программу, которая принимает на вход число и выдает кол-во цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int DigitCount(int A)
{
    int Count = 0;
    if (A == 0)
    {
        Count = 1;
    }
    else
    {
        while (A != 0)
        {
            A /= 10;
            Count++;
        }
    }
    return Count;
}
Console.Clear();
Console.Write("Enter number: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Length of {N} is {DigitCount(N)}");