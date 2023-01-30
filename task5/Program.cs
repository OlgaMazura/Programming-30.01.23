// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.WriteLine("Enter number 1: ");
int n1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter number 2: ");
int n2 = int.Parse(Console.ReadLine()!);
int sqr1 = n1 * n1;
int sqr2 = n2 * n2;
if (sqr1 == n2 || sqr2 == n1)
{
    Console.WriteLine($"YES!");
}
else
{
    Console.WriteLine($"NO!");
}