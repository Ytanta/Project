// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

int[] arr = CreateArraeRndInt(5,1,9);
PrintArray(arr);
int[] copyArray = CopyArray (arr);
Console.WriteLine();
PrintArray(copyArray);

int[] CopyArray (int[] mass)
{
    int[] newArray = new int[mass.Length];
for (int i = 0; i < mass.Length; i++)
{
    newArray[i] = mass[i];
}
return newArray;
}

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