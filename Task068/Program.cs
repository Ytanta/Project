// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// функция ack(n, m)
//    если n = 0
//      вернуть m + 1
//    иначе, если m = 0
//      вернуть ack (n - 1, 1)
//    еще
//      вернуть ack(n - 1, ack (n, m - 1))

Console.WriteLine("Введите число");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int numberN = Convert.ToInt32(Console.ReadLine());


int ack = Ack(numberM, numberN);
Console.WriteLine($"m = {numberM}, n = {numberN} -> A({numberM},{numberN}) = {ack}");





int Ack(int numM, int numN)
{
    if (numM == 0) return numN + 1;
    else if (numN == 0 && numM > 0) return Ack(numM - 1, 1);
    else return Ack(numM - 1, Ack(numM, numN - 1));
}