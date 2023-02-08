// Напишите программу, которая принимает на вход число N и выдает произведение чисел от 1 до N
// 4 -> 24, 5 -> 120

Console.Clear();

int Multi(int N)
{
    int S = 1;
    for (int i = 1; i <= N; i++)
    {
        S *= i; // S = S * i
    }
    return S;
}


Console.WriteLine("Enter number: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Multiplication of numbers {N} is {Multi(N)}"!);
