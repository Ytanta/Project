// Задача 52. Задайте двумерный массив из целых чисел.
//  Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("|");
    }
}
void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{Math.Round(arr[i],1),4}");
        else Console.Write($"{Math.Round(arr[i],1),4}");
    }
    Console.Write("]");
}
double[] ArithmeticMeanArr(int[,] arr)
{
    double[] sum = new double [arr.GetLength(1)];
    
for (int j = 0; j < arr.GetLength(1); j++)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
    
        sum[j] += arr[i,j];
    }
    sum[j]/=arr.GetLength(1);
    
}
return sum;
}

int[,] array2D = CreateMatrixRndInt(4, 6, 1, 10);
PrintMatrix(array2D);
double[] arithmeticMeanArr = ArithmeticMeanArr(array2D);
PrintArray(arithmeticMeanArr);
