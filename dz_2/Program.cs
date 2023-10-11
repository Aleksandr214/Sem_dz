System.Console.WriteLine("Введите число");

string number = Console.ReadLine();
int number1 = int.Parse(number);


if (number1 % 2 == 1)
{
    Console.WriteLine($"Число {number1} является нечетным");
}
else
{
    Console.WriteLine($"Число {number1} является четным");
}