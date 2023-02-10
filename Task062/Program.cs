
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

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

int[,] SpiralMatrix(int rows, int columns)
{
int[,] Matrix = new int[rows, columns];
int count = 1;
int i = 0;
int j = 0;

while (count <= Matrix.GetLength(0) * Matrix.GetLength(1))
{
  Matrix[i, j] = count;
  count++;
  if (i <= j + 1 && i + j < Matrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= Matrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > Matrix.GetLength(1) - 1)
    j--;
  else
    i--;
}
return Matrix;
}
Console.WriteLine("Введите количество строк:");
int Rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int Columns = Convert.ToInt32(Console.ReadLine());
if (Rows==Columns)
{
int [,] spiralMatrix = SpiralMatrix(Rows,Columns);
PrintMatrix(spiralMatrix);
}
else Console.WriteLine("Невозможно построить спиральную матрицу");
