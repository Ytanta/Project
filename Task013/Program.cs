// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//  Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.WriteLine("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99)
{
    int thirdDigit = ThirdDigit(number);
    Console.WriteLine(thirdDigit);
    int ThirdDigit(int num)
    {
        int result = 0;
        if (num >= 100)
        {
            while (num > 999)
            {
                num = num / 10;
            }
            result = num % 10;
        }
        return result;
    }
}
else
{
    Console.WriteLine("третьей цифры нет");
}