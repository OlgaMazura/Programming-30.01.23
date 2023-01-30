Console.Clear();

Console.Write("Enter three-digit number: ");
int n = int.Parse(Console.ReadLine());

int n1 = n % 100;
int n2 = n % 10;
int result = (n1 - n2)/10;

Console.Write($"{result}"!);
