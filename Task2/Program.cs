﻿// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
System.Console.Write("Введите первое число: ");
int numericFirst = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число: ");
int numericSecond = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите третье число: ");
int numericThird = Convert.ToInt32(Console.ReadLine());
int max = numericFirst;
if (max < numericSecond)
{
    max = numericSecond;    
}
if (max < numericThird)
{
    max = numericThird; 
}
System.Console.WriteLine("Наибольшее из трех чисел: " + max);