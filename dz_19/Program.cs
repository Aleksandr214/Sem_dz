// Функция ввода 
int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

// Заполнение массива рандомными вещественными числами
void FillArray2D(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-99, 99) / 10.0;
        }
    }
}

//  Функция вывода массива в терминал
void PrintArray2D(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int rows = ReadInt("Введите количество строк: ");
int colums = ReadInt("Введите количество столбцов: ");
double[,] array = new double[rows, colums];
FillArray2D(array);
PrintArray2D(array);