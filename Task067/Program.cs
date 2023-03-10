// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9
// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8
//  int FactorialRec(int n)
// {
// if (n == 1) return 1;
// else return n * FactorialRec(n - 1);
// }

// Console.WriteLine(FactorialRec(10)); // 3628800

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());


int sumnumber = SumNumber(number);
Console.WriteLine($"Сумма цифр числа {sumnumber}");

int SumNumber(int num)
{
    if(num==0) return 0;
    else return (num%10 + SumNumber(num /10));
}