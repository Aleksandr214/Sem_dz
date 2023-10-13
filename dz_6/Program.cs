//Задача 13: выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99)
{
    while (number > 999)
    {
        number /= 10;
    }
    Console.WriteLine(number % 10 );
}
else
{
    Console.WriteLine("ошибка ");
}