// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

System.Console.Write("Введите первое число N: ");
int numeric = Convert.ToInt32(Console.ReadLine());
int i = 2;
while (i<=numeric)
{
    if (i == numeric | (i+1) == numeric)
    {
        System.Console.Write(i);
    }
    else
    {
        System.Console.Write(i + ", ");
    }
    i+=2;
}