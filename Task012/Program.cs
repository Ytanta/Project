﻿// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите целое первое число:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое второе число:");
int num2 = Convert.ToInt32(Console.ReadLine());
{
    if (num1 % num2 == 0)
        Console.WriteLine("Кратно");
    else
    Console.WriteLine($"Остаток -> {num1 % num2}");
}
