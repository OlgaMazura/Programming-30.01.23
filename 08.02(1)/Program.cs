//Напишите программу, которая принимает на вход число (А) и выдает сумму всех чисел от 1 до (А).
// 7 -> 28
// 4 -> 10
// 8 -> 36

int GetSumm(int A)
{
    int Sum = 0;
    for (int i = 1; i <= A; i++)
    {
        Sum += i; // Sum = Sum + i
    }
    return Sum;
}
Console.Clear();
Console.Write("Enter number: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Summ from 1 to {N} is {GetSumm(N)}");
// ВАЖНО!! Фуннкциюобъявляем в начале!!
