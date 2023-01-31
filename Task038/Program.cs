// Задача 38: Задайте массив вещественных чисел.
//  Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArraeRndInt(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(num,1);
    }
    return arr;
}
void PrintArrayDouble(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}
double maxDouble(double[] massive)
{
    double max = massive[0];

for (int i = 0; i < massive.Length; i++)
{
    if(massive[i] > max)
    max = massive[i];
}
return max;
}
double minDouble(double[] massive)
{
    double min = massive[0];

for (int i = 0; i < massive.Length; i++)
{
    if(massive[i] < min)
    min = massive[i];
}
return min;
}
double[] arr = CreateArraeRndInt(4, -10, 10);
PrintArrayDouble(arr);
double maxdouble = maxDouble(arr);
double mindouble = minDouble(arr);
Console.Write($" -> {Math.Round(maxdouble - mindouble, 1)}");