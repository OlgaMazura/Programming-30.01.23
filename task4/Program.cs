// Напишите программу, которая принимает на вход
// число и проверяет, кратно ли оно одновременно
// 7 и 23.
// ● 14 -> нет
// ● 46 -> нет
// ● 161 -> да

Console.Clear();
Console.Write("Enter number: ");
int n = int.Parse(Console.ReadLine()!);
if (n % 7 == 0 && n % 23 == 0)
{
    Console.WriteLine("YES!");
}
else
{
    Console.WriteLine("NO!");
}