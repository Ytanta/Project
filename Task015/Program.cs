// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите номер дня:");
int number = Convert.ToInt32(Console.ReadLine());
if (0 < number & number < 8)
{
    bool weekend = Weekend(number);
    Console.WriteLine(weekend ? "Да" : "Нет");

    bool Weekend(int num)
    {
        return num > 5;
    }
}
else
{
    Console.WriteLine("Некорректный номер");
}