Console.Clear();
Console.WriteLine("Enter number from 1 to 7: ");
int DAY = int.Parse(Console.ReadLine()!);

if(DAY==6 || DAY==7)
{
    Console.WriteLine($"YES!");
}
else
{
    Console.WriteLine($"NO!");
}