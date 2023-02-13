Console.Clear();
float[] GetArray(int size, float MinValue, float MaxValue)
{
    float[] Result = new float[size];

    for (int i = 0; i < size; i++)
    {
        Result[i] = new Random().Next(MinValue, MaxValue +1);
    }
    return Result;
}
float[] array = GetArray(5, 1, 100);
Console.WriteLine(string.Join("; ", array));
// Console.WriteLine("Введите размер массива  ");
// int size = Convert.ToInt32(Console.ReadLine());
// double[] numbers = new double[size];
// FillArrayRandomNumbers(numbers);
// Console.WriteLine("массив: ");
// PrintArray(numbers);
// double min = Int32.MaxValue;
// double max = Int32.MinValue;

// for (int z = 0; z < numbers.Length; z++)
// {
//     if (numbers[z] > max)
//         {
//             max = numbers[z];
//         }
//     if (numbers[z] < min)
//         {
//             min = numbers[z];
//         }
// }

// Console.WriteLine($"всего {numbers.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
// Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

// void FillArrayRandomNumbers(double[] numbers)
// {
//     for(int i = 0; i < numbers.Length; i++)
//         {
//             numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
//         }
// }
// void PrintArray(double[] numbers)
// {
//     Console.Write("[ ");
//     for(int i = 0; i < numbers.Length; i++)
//         {
//             Console.Write(numbers[i] + " ");
//         }
//     Console.Write("]");
//     Console.WriteLine();
// }
