﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

System.Console.Write("Введите первое число N: ");
int numeric = Convert.ToInt32(Console.ReadLine());
if (numeric%2 == 0)
{
    System.Console.WriteLine("Число " + numeric +" является четным.");
}
else
{
    System.Console.WriteLine("Число " + numeric +" является нечетным.");
}