// на вход принимает два числа и выводит, какое число большее, а какое меньшее.
Console.WriteLine("Пожалуйста введите 2 числа,");
Console.WriteLine("чтобы узнать какое большее, а какое меньшее.");
Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
if (a > b)
{
    Console.WriteLine("Число " + a + " большее");
    Console.Write("Число " + b + " меньшее");
}
else if (a == b)
{
    Console.WriteLine("Число " + a + " равно числу " + b);
}
else
{
    Console.WriteLine("Число " + b + " большее");
    Console.Write("Число " + a + " меньшее");
}