// адача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

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
        if (i < arr.Length - 1) Console.Write($"{(arr[i]),3}");
        else Console.Write($"{(arr[i]),3}");
    }
    Console.Write("]");
}
int[] RemoteMatrixArray(int[,] matrix)
{
    int arraysize = matrix.Length;
    int[] array = new int[arraysize];
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[count] = matrix[i, j];
            count++;
        }

    }
    return array;
}
void FrequencyDicionery(int[] array)
{
    int count = 1;
    int num = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] == num)
            count++;
        
        else 
        {
            Console.WriteLine($"Число {num} встречается {count} раз");
        num = array[i];
        count = 1;
        }
    }
    Console.WriteLine($"Число {num} встречается {count} раз");
}


int[,] array2D = CreateMatrixRndInt(4, 5, 0, 10);
PrintMatrix(array2D);
int[] allNum = RemoteMatrixArray(array2D);
Array.Sort(allNum);
Console.WriteLine();
PrintArray(allNum);
Console.WriteLine();
FrequencyDicionery(allNum);