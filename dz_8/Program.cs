// принимает на вход пятизначное число number и проверяет, является ли оно палиндромом.
//Метод должен проверить является ли число пятизначным, в противном случае - вывести Число не пятизначное и False в следующей строке.
//Для остальных чисел вернуть True или False.
Console.WriteLine("Введите число: ");
string? number = Console.ReadLine();
int len = number.Length;

if (len == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"{number} - Палиндром");
    }
    else
    {
       Console.WriteLine($"{number} - НЕ палиндром");
    }
}
else
{
    Console.WriteLine($"ОШИБКА: {number} - не является пятизначным");
} 


//static bool IsPalindrome(int number)
    //{
      //  if (number < 10000 || number >= 100000){
            //Console.WriteLine("Число не пятизначное");
            //return false;
        //}

        //int reverse = 0;
        //int temp = number;
        //while (temp > 0){
            //reverse = reverse * 10 + temp % 10;
            //temp /= 10;
        //}
        //return reverse == number;
    //}

