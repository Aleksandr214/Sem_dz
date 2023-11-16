//Задача 54: Задайте двумерный массив.
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.WriteLine("введите количество строк");
int linVol = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int colVol = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[linVol, colVol];
FillArrayRandomNumbers(numbers);
Console.WriteLine();
Console.WriteLine("Массив до изменения");
PrintArray(numbers);

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1) - 1; j++)
    {
        for (int z = 0; z < numbers.GetLength(1) - 1; z++)
        {
            if (numbers[i, z] < numbers[i, z + 1]) //для изменения сортировки поменять знак < на противоположный
            {
                int temp = 0;
                temp = numbers[i, z];
                numbers[i, z] = numbers[i, z + 1];
                numbers[i, z + 1] = temp;
            }
        }
    }
}
Console.WriteLine();
Console.WriteLine("Массив с упорядоченными значениями");
PrintArray(numbers);

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
// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Введите количество строк:");
//         int rows = Convert.ToInt32(Console.ReadLine());

//         Console.WriteLine("Введите количество столбцов:");
//         int columns = Convert.ToInt32(Console.ReadLine());

//         int[,] array = new int[rows, columns];
//         FillArrayRandomNumbers(array);

//         Console.WriteLine("Массив до сортировки:");
//         PrintArray(array);

//         SortRowsDescending(array);

//         Console.WriteLine("Массив после сортировки:");
//         PrintArray(array);
//     }

//     static void SortRowsDescending(int[,] array)
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             Array.Sort(GetRow(array, i), (a, b) => b.CompareTo(a));
//         }
//     }

//     static int[] GetRow(int[,] array, int row)
//     {
//         int[] result = new int[array.GetLength(1)];
//         for (int i = 0; i < array.GetLength(1); i++)
//         {
//             result[i] = array[row, i];
//         }
//         return result;
//     }

//     static void FillArrayRandomNumbers(int[,] array)
//     {
//         Random random = new Random();
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 array[i, j] = random.Next(0, 100); // Меняйте диапазон случайных чисел по необходимости
//             }
//         }
//     }

//     static void PrintArray(int[,] array)
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 Console.Write(array[i, j] + " ");
//             }
//             Console.WriteLine();
//         }
//     }
// }
