// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

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

        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("]");
    }
}
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{(arr[i]),2}");
        else Console.Write($"{(arr[i]),3}");
    }
    Console.Write("]");
}
int[] MatrixMinElement(int[,] array)
{
    int[] result = new int[2];
    int min = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                result[0] = i;
                result[1] = j;
            }
        }
    }
    return result;
}
int[,] DeleteMinNumRowsColumns(int[,] matrix, int[] array)
{
    int rowsCount = matrix.GetLength(0) - 1;
    int columnsCount =  matrix.GetLength(1) - 1;
    int[,] resultMatrix = new int[rowsCount,columnsCount];
    int m = 0;
    int n = 0;
    
    for (int i = 0; i < rowsCount; i++)
    {
        if (m == array[0]) m++;
         n = 0;

        for (int j = 0; j < columnsCount; j++)
        {
            if (n == array[1]) m++;
            resultMatrix[i, j] = matrix[m, n];
            n++;
        }
        m++;
    }
    return resultMatrix;
}
int[,] array2D = CreateMatrixRndInt(4, 4, 0, 10);
PrintMatrix(array2D);
int[] matrixMinNum = MatrixMinElement(array2D);
PrintArray(matrixMinNum);
int[,] Resultmatrix = DeleteMinNumRowsColumns(array2D, matrixMinNum);
Console.WriteLine();
PrintMatrix(Resultmatrix);