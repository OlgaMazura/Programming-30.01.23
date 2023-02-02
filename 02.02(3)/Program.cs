// // Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

//  • A (3,6); B (2,1) -> 5,09 
//  • A (7,-5); B (1,-1) -> 7,21
Console.Clear();
Console.WriteLine("Введите X1: ");
int X1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите X2: ");
int X2 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите Y1: ");
int Y1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите Y2: ");
int Y2 = int.Parse(Console.ReadLine()!);
double X = Math.Pow(X2 - X1, 2);
double Y = Math.Pow(Y2 - Y1, 2);

double RESULT = Math.Sqrt(X + Y);
Console.WriteLine(Math.Round(RESULT, 2));
// или Console.WriteLine($"{RESULT:f2}!);