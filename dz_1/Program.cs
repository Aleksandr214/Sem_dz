﻿Console.WriteLine("Введите три числа, и узнайте, ");
Console.WriteLine("какое из них имеет максимальное значение.");

Console.Write("Введите первое число и нажмите ENTER: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число и нажмите ENTER: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите третье число и нажмите ENTER: ");
int c = int.Parse(Console.ReadLine());
int maxNum = 0;
if (a > maxNum) maxNum = a;
if (b > maxNum) maxNum = b;
if (c > maxNum) maxNum = c;
Console.Write("Максимальное значение имеет число " + maxNum);