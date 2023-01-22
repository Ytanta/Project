// Задача 19

// Напишите программу, которая принимает на вход пятизначное число
//  и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

// Console.WriteLine("Введите пятизначное число");
// int number = Convert.ToInt32(Console.ReadLine());
// int revers = Revers(number);
// // void result = number == revers
// //  ?  Console.WriteLine("Да")
// //  :  Console.WriteLine("Нет");
// Console.WriteLine(revers);
// int Revers(int num)
// {
// while (num > 0)
// {
//     int reminder, reverse = 0;
//     reminder = number % 10;
//     num = num / 10;
//     reverse = (reverse * 10) + reminder;
//     return reverse;

// }
// return 0;
// }
Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
int reminder, reverse = 0;
int revers = Revers(number);
if (number == revers)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
int Revers(int num)
{
    while (num > 0)
    {
        reminder = num % 10;
        reverse = (reverse * 10) + reminder;
        num = num / 10;

    }
    return reverse;
}

