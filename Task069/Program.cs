﻿// Задача 69: Напишите программу, которая на вход принимает два числа A и B,
//  и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8
Console.WriteLine("Введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());


int powernum = PowerNumbers(numberA, numberB);
Console.WriteLine($"Первое число в степени второго {powernum}");

int PowerNumbers(int numA, int numB)
{
    if (numB == 0) return 1;
    else return numA* PowerNumbers(numA, numB - 1);

}