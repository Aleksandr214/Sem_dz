// на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
int b = 2;

while (a >= b)
{
    Console.Write(b + " ");
    b = b + 2;
}