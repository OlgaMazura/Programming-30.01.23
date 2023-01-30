Console.Clear();

Console.Write("Enter number: ");
int n = int.Parse(Console.ReadLine()!);
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
            // // Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
            // Console.Write("Введите любое число: ");
            // num = Convert.ToInt32(Console.ReadLine());
            // string numStr = Convert.ToString(num);
            // numDigit = numStr.Length;
            // if (numDigit > 2) Console.WriteLine($"Третья цифра введённого числа: {numStr[2]}");
            // else Console.WriteLine("третьей цифры нет");
            // break;