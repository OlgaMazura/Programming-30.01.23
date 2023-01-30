Console.Clear();

Console.Write("Enter number: ");
int n = int.Parse(Console.ReadLine());
int k = 10;
int result = n % k;

if (n < 99)
{
    Console.WriteLine($"There is no third number"!);
}
else
{
    Console.WriteLine($"{result}"!);
}


// int index = 0;

// while (index < n)
// {

//     if(array[index] == find)
//     {
//         Console.WriteLine(index);
//     }

//     index++;
// }