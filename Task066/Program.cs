// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.WriteLine("Введите первое натуральное число");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberM <=0 && numberN<=0)
{
    Console.WriteLine("Некорректные числа");
}
else
{
int sumallelements = SumAllElements(numberM, numberN);
Console.WriteLine($"M = {numberM}; N = {numberN} -> {sumallelements}");
}
int SumAllElements(int numM, int numN)
{
    if (numM == numN) return numM;
    else if (numM < numN) return numN + SumAllElements(numM, numN - 1);
    else return numN + SumAllElements(numM, numN + 1);
}