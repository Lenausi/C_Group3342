// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координаты первой точки");
Console.Write("X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки");
Console.Write("X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double Range (int a1, int b1, int a2, int b2)
{
int rangeA = a1 - a2;
int rangeB = b1-b2;
double range = Math.Sqrt(rangeA*rangeA + rangeB*rangeB);
return range;
}

double result = Range (x1, y1, x2, y2);
System.Console.WriteLine($"Расстояние между точками в 2D пространстве = {Math.Round(result, 2,  MidpointRounding.ToZero)}");