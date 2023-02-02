// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.WriteLine("Введите число:");
int number; 
if(int.TryParse(Console.ReadLine(), out number))
{ 
int result = NumBinary(number);
Console.WriteLine($"{number} -> {result}");
}
else Console.WriteLine("Некорректное число");


int NumBinary(int num)
{
    int numbrtBin = 0;
    int count = 1;
    while (num > 0)
    {
        numbrtBin = numbrtBin + (num % 2 * count);
        num /= 2;
        count *= 10;
    }
    return numbrtBin;
}

// Console.WriteLine("Введите десятичное число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// string Binary(int num)
// {
// string res = string.Empty;
// while (num > 0)
// {
// res = num % 2 + res;
// num = num / 2;

// }
// return res;
// }

// string binary = Binary(number);
// Console.Write($"{number} -> {binary}");