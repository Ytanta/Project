﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());
const string quote = "\"";
Console.Write($"N = {number} ->  {quote}");
NaturalNumber(number);
Console.Write(quote);
void NaturalNumber(int num)
{
    {
        if (num == 0) return;
        Console.Write($"{num}");
        Console.Write(num > 1 ? ", " : "");
        NaturalNumber(num - 1);
    }
}