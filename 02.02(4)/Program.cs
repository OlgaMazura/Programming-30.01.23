// Напишите программу, которая принимает на вход
// число (N) и выдаёт таблицу квадратов чисел
// от 1 до N.

Console.Clear();
Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
int I = 1;

while (I <= N)
{
    Console.Write($"{Math.Pow(I,2)}");
    if (I != N)
    {
        Console.Write(", ");
    }
    I++;
}