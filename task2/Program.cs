Console.Clear();

int num = new Random().Next(100, 1000);
Console.WriteLine(num);

int a1 = num / 100;
int a2 = num % 10;
int a3 = a1 * 10 + a2;
Console.Write($"{num} -> {a3}");
