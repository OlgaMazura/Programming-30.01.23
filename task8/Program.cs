Console.Clear();

Console.Write("Enter number: ");
int number = int.Parse(Console.ReadLine()!);

while (number > 999)
{
    number = number / 10;
}
int count = 10;
int result = number % count;
if (number < 99)
{
    Console.WriteLine($"There is no third number"!);
}
else
{
    Console.WriteLine($"{result}"!);
}
// int result = n % k;

// if (n < 99)
// {
//     Console.WriteLine($"There is no third number"!);
// }
// else
// {
//     Console.WriteLine($"{result}"!);
// }
