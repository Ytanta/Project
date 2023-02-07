// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите количсетво чисел:");
int M = Convert.ToInt32(Console.ReadLine());
int[] UserArray = CreateArraeInt(M);
PrintArray(UserArray);
int positiveNum = PositiveNum(UserArray);
Console.Write($" -> {positiveNum}");

int PositiveNum(int[] array)
{
    int result=0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) result++;
    }
    return result;
}
int[] CreateArraeInt(int m)
{
    int[] array = new int[m];
    for (int i = 0; i < m; i++)
    {
        Console.WriteLine("Введите число:");
        array[i] = int.Parse(Console.ReadLine()!);
    }
    return array;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}