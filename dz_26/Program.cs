//Задача 62: Заполните спирально массив 4 на 4.
// списал у лектора... Сам бы не осилил((( 

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());

int[,] nums = new int[size, size];

int num = 1;
int i = 0;
int j = 0;

while (num <= size * size)
{
    nums[i, j] = num;
    if (i <= j + 1 && i + j < size - 1)
        ++j;
    else if (i < j && i + j >= size - 1)
        ++i;
    else if (i >= j && i + j > size - 1)
        --j;
    else
        --i;
    ++num;
}

PrintArray(nums);

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

//треугольник Паскаля
// using System;

// class PascalTriangle
// {
//     static void Main()
//     {
//         int rows;

//         Console.WriteLine("Введите количество строк для треугольника Паскаля: ");
//         while (!int.TryParse(Console.ReadLine(), out rows) || rows <= 0)
//         {
//             Console.WriteLine("Введите положительное целое число: ");
//         }

//         PrintPascalTriangle(rows);
//     }

//     static void PrintPascalTriangle(int rows)
//     {
//         for (int i = 0; i < rows; i++)
//         {
//             int number = 1;
//             for (int j = 0; j <= i; j++)
//             {
//                 Console.Write(number + " ");
//                 number = number * (i - j) / (j + 1);
//             }
//             Console.WriteLine();
//         }
//     }
// }

