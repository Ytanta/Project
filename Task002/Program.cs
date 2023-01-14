// 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите целое первое число:");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое второе число:");
int number1 = Convert.ToInt32(Console.ReadLine());
if (number==number1)
{
    Console.WriteLine("Некоректные числа");
}

else if (number > number1)
{
   
    Console.WriteLine($"Большее число {number}. Меньшее число {number1}");
}
else
{
    Console.WriteLine($"Большее число {number1}. Меньшее число {number}");
}
