// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.WriteLine("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число:");
int c = Convert.ToInt32(Console.ReadLine());



bool TriangleExists (int a, int b, int c)
{
    if(a <b+c && b < a + c && c < a + b) return true;
else return false;
}
 bool res = TriangleExists ( a, b,  c);
 Console.WriteLine(res ? "Да": "Нет");
