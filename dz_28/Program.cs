// Задача 66: Задайте значения M и N.
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int sum = CalculateSum(M, N);
Console.WriteLine($"Сумма натуральных чисел от {M} до {N} равна: {sum}");

int CalculateSum(int m, int n)
{
    if (m > n)
    {
        int temp = m;
        m = n;
        n = temp;
    }

    int sum = 0;
    for (int i = m; i <= n; i++)
    {
        sum += i;
    }
    return sum;
}
