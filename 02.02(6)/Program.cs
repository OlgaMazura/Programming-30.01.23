// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.WriteLine("Enter 5-digit number: ");
int N = int.Parse(Console.ReadLine()!);
int A1 = N / 10000,  A2 = N % 10, B1 = (N / 1000) % 10, B2 = (N / 10) % 10;

if (A1==A2 && B1==B2)
{
    Console.WriteLine($"YES!"!);
}
else
{
    Console.WriteLine($"NO!"!);
}