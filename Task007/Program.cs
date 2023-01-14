// 7. Напигите программу, которая принимает на вход
// трехзначное число и на выходе показывает последнюю цифру 
// этого числа.
//    456 -> 6
//    782 -> 2
//    918 -> 8

Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if 
(99 < num & num<1000)
{
    int res = num % 10;
    Console.WriteLine(res);
}
else
{
    Console.WriteLine("Ошибка");
}