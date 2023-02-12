// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

Console.WriteLine("Введите первое натуральное число");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число");
int M = Convert.ToInt32(Console.ReadLine());

NaturalNumber(N, M);

void NaturalNumber(int numM, int numN)
{
    if (numM < numN)
    {
        Console.Write($"{numM} ");
        NaturalNumber(numM + 1, numN);
    }

    else if (numM > numN)
{
    NaturalNumber(numM - 1, numN);
    Console.Write($"{numM} ");
}
else Console.Write($"{numN} ");
}