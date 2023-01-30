// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] CreateArraeRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
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
int countNumbers (int[] massive)
{
    int result = 0;
    for (int i = 0; i < massive.Length; i++)
    {
        if (massive[i] % 2 ==0) result++;
    }
    return result;
}
int[] arr = CreateArraeRndInt(4,100,999);
PrintArray(arr);
int countnum = countNumbers(arr);
Console.Write($" -> {countnum}");