Console.Clear();

Console.Write("Enter number: ");
int number = int.Parse(Console.ReadLine()!);
int count = 10;
int result = number % count;

while (number > 999)
{   
    count = count * 10;
}
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
