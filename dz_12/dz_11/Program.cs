//Задача 25: Напишите цикл, который принимает на вход
//два числа (A и B) и возводит число A в натуральную
//степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int numberA=ReadInt("Введите число А: ");
int numberB=ReadInt("Введите число B: ");
ToDegree(numberA, numberB);

//функция возведения в степень:
void ToDegree(int a, int b)
{
    int result=1;
    for (int i = 1; i <=b; i++)
    {
        result=result * a;
    }
    Console.WriteLine(result);
}

int ReadInt(string text)


{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int Prompt(string messag)
{
    Console.Write(messag);
    string? readInput=Console.ReadLine();
    int result=int.Parse(readInput);
    return result;

}

int power(int powerBase, int exponent)
{
    int power=1;
    for (int i = 0; i < exponent; i++)
    {
        power *=powerBase;
    }
    return power;
}
bool ValidateExponent(int exponent)
{
    if(exponent<0)
    {
        Console.WriteLine("покозатель не должен быть меньше нуля");
        return false;
    }
    return true;
}
int powerBase=Prompt("Введите основание:");
int exponent=Prompt("Введите покозатель:");
if (ValidateExponent(exponent))
{
    Console.WriteLine($"число {powerBase} в степени {exponent} равно {power(powerBase, exponent)}");
}