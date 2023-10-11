//написать прогграмму,на входе 3х значное число и на выходе показывает 2-ю цифру этого числа.
Console.Write("Введите трех значное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number>999||number<100)
{
    Console.WriteLine("Вы ввели не трех значное число: ");
}
else
{
    Console.WriteLine(number % 100/10); 
}
