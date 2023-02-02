// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// 5 * x + 2 = 9 * x + 4




Console.WriteLine("Введите первую точку для первой прямой");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую точку для первой прямой");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первую точку для второй прямой");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую точку для второй прямой");
double k2 = Convert.ToInt32(Console.ReadLine());
if (k1 == k2 && b1 == b2)
{
    Console.WriteLine("Прямые совпадающие");

}
else if (k1 == k2 || b1 == b2)
{
    Console.WriteLine("Прямые параллельны");
    
}
else
{
    double SearchX = searchX(k1, k2, b1, b2);
    double SearchY = searchY(SearchX, k1, b1);
    Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> {SearchX}; {SearchY} ");
   
}

double searchX(double K1, double K2, double B1, double B2)
{
    double x = (B2 - B1) / (K1 - K2);
    return Math.Round(x,1);
}
double searchY(double X, double Ka, double Ba)
{
    double y = Ka * X + Ba;
    return Math.Round(y,1);
}

// int x=(b2-b1) / (k1-k2);
// int y = k1 * x +b1;


