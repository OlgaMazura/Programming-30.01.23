// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n. 
// m = 2, n = 3 -> A(m,n) = 9

Console.Clear();

int Akkerman(int M, int N)
{
  if (M == 0) return N + 1;
  else if (N == 0) return Akkerman(M - 1, 1);
  else return Akkerman(M - 1, Akkerman(M, N - 1));
}

Console.Write($"Enter number 1: "!);
int M = int.Parse(Console.ReadLine()!);
Console.Write($"Enter number 2: "!);
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine(Akkerman(M,N));