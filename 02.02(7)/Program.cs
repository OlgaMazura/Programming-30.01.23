// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.Clear();
Console.WriteLine("Enter X1: ");
int X1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter Y1: ");
int Y1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter Z1: ");
int Z1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter X2: ");
int X2 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter Y2: ");
int Y2 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter Z2: ");
int Z2 = int.Parse(Console.ReadLine()!);

double X = Math.Pow(X2 - X1, 2);
double Y = Math.Pow(Y2 - Y1, 2);
double Z = Math.Pow(Z2 - Z1, 2);

double RESULT = Math.Sqrt(X + Y + Z);
Console.WriteLine($"{RESULT:f2}"!);