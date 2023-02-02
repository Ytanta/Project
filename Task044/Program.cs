// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.WriteLine("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());
int[] fibArray = Fibonacci(N);
PrintArray(fibArray);

int[] Fibonacci(int n)
{
    
    int [] fibarray = new int[n];
    fibarray[0] = 0;
    fibarray[1] = 1;
   for (int i = 2; i < n; i++)
   {
    fibarray[i] = fibarray[i-1]+fibarray[i-2];
   }
   return fibarray;
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