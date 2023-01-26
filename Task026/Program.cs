// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int countnumbers = CountNumbers(number);
Console.WriteLine(countnumbers);
int CountNumbers(int num)
{
    if(num<0) num = num * -1;
int count = 0;
   for (int i = 1; num>1; i++)
    {
        num=num/10;
        count = i;
    }
    
    return count;
 
}
