// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵) ; 2, 4 -> 16

Console.Clear();
Console.WriteLine("Enter number 1: ");
int N1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter number 2: ");
int N2 = int.Parse(Console.ReadLine()!);

Console.WriteLine($"{Math.Pow(N1, N2)}"!);