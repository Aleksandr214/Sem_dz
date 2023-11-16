//Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.WriteLine("введите размер квадратного массива");
int massVol = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[massVol, massVol];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
int minsum = Int32.MaxValue;
int indexLine = 0;

for (int i = 0; i < numbers.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        sum = sum + numbers[i, j];        
    }
    if (sum < minsum)
    {
        minsum = sum;
        indexLine++;
    }
}

Console.WriteLine("строка с наименьшей суммой елементов под номером: " + (indexLine) + ", с суммой елементов равной: " + (minsum));

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
   
//     Console.WriteLine("Введите количество строк:");
//     int rows = Convert.ToInt32(Console.ReadLine());

//     Console.WriteLine("Введите количество столбцов:");
//     int columns = Convert.ToInt32(Console.ReadLine());

//     int[,] array = new int[rows, columns];
//     FillArrayRandomNumbers(array);

//     Console.WriteLine("Массив:");
//     PrintArray(array);

//     int minSumRow = FindRowWithMinSum(array);
//     Console.WriteLine($"Строка с наименьшей суммой элементов: {minSumRow}");
    

//  int FindRowWithMinSum(int[,] array)
// {
//     int minRow = 0;
//     int minSum = int.MaxValue;

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int currentSum = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//              currentSum += array[i, j];
//         }

//         if (currentSum < minSum)
//         {
//             minSum = currentSum;
//             minRow = i;
//         }
//     }

//     return minRow;
// }

//  void FillArrayRandomNumbers(int[,] array)
// {
//     Random random = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = random.Next(0, 10); // Меняйте диапазон случайных чисел по необходимости
//         }
//     }
// }

//  void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }
