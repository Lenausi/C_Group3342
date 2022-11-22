// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите b1 для первой прямой y = k1 * x + b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k1 для первой прямой y = k1 * x + b1: ");
int k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите b2 для первой прямой y = k1 * x + b1: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k2 для первой прямой y = k1 * x + b1: ");
int k2 = Convert.ToInt32(Console.ReadLine());

double CrossPoint (int bb1,int  kk1, int bb2, int kk2)
{
double x1 = (bb2-bb1);
double x2 = (kk1-kk2);
double x = Math.Round(x1/x2,2);
// double x = Math.Round((bb2-bb2)/(kk1-kk2),2);
return x;
}

double result = CrossPoint(b1, k1, b2, k2);
System.Console.WriteLine($"Координаты точки пересечения двух прямых ({result}, {result})");


