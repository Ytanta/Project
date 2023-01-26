// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine("Введите число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральную степень, в которую возведется первое число ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberB < 0)
{
    Console.WriteLine("Некорректное число");
}
else
{
int extent = Extent (numberA, numberB);
Console.WriteLine($"{numberA}, {numberB} -> {extent}");
}

int Extent(int numA, int numB)
{
    int multip = 1;
    for (int i = 1; i <= numB; i++)
    {
        multip = multip * numA;
    }
    return multip;
}