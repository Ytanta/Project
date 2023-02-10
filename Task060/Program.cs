// *Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

// int[,,] CreateMatrix3D(int row, int col, int dep, int min, int max)
// {
//     int[,,] matrix = new int[row, col, dep];
//     Random rnd = new Random();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             for (int k = 0; k < matrix.GetLength(2); k++)
//             {
//                 matrix[i, j, k] = rnd.Next(min, max + 1);

//             }
//         }
//     }
//     return matrix;
// }

// int[,,] NnrepeatingNumber(int[,,] matrix3d, int min, int max)
// {
//     Random rnd = new Random();
//     for (int n = 0; n < matrix3d.GetLength(0); n++)
//     {

//         for (int m = 0; m < matrix3d.GetLength(1); m++)
//         {

//             for (int l = 0; l < matrix3d.GetLength(2) -1; l++)
//             {

//                 for (int i = 0; i < matrix3d.GetLength(0); i++)
//                 {
//                     for (int j = 0; j < matrix3d.GetLength(1); j++)
//                     {
//                         for (int k = 0; k < matrix3d.GetLength(2); k++)
//                         {
//                             if (matrix3d[n, m, l+1] == matrix3d[i, j, k])
//                             {
//                                 matrix3d[n, m, l] = rnd.Next(min, max + 1);

//                             }

//                         }
//                     }
//                 }
//             }
//         }
//     }
//     return matrix3d;
// }
// void PrintMatrix(int[,,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write("|");
//             for (int k = 0; k < matrix.GetLength(2); k++) { Console.Write($"{matrix[i, j, k],1}({i},{j},{k})|"); }
//             Console.WriteLine();
//         }
//     }
// }
// int[,,] matrix3D = CreateMatrix3D(2, 2, 2, 10, 18);

// PrintMatrix(matrix3D);
// Console.WriteLine();
// matrix3D = NnrepeatingNumber(matrix3D, 10,18);
// PrintMatrix(matrix3D);