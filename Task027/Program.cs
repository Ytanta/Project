// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int sumdigits = Sumdigits(number);
Console.WriteLine($"{number} -> {(int)Math.Abs(sumdigits)}");
int Sumdigits(int num)
{
    int remains, result = 0;
   while ((int)Math.Abs(num) > 0)
    {
        remains = num % 10;
        result = result  + remains;
        num = num / 10;

    }
    return result;
}
