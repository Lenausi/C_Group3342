// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты первой точки");;
Console.Write("Х1 =  ");
int x1 = Convert.ToInt32(Console.ReadLine ( ));
Console.Write("Y1 =  ");
int y1 = Convert.ToInt32(Console.ReadLine ( ));
Console.Write("Z1 =  ");
int z1 = Convert.ToInt32(Console.ReadLine ( ));

Console.WriteLine("Введите координаты второй точки");;
Console.Write("Х2 =  ");
int x2 = Convert.ToInt32(Console.ReadLine ( ));
Console.Write("Y2 =  ");
int y2 = Convert.ToInt32(Console.ReadLine ( ));
Console.Write("Z2 =  ");
int z2 = Convert.ToInt32(Console.ReadLine ( ));



double Pifagor (int a1, int b1, int a2, int b2, int c1, int c2)
{
    double result  = Math.Sqrt((a2-a1)*(a2-a1)+(b2-b1)*(b2-b1)+(c2-c1)*(c2-c1));
    return result;
}

double distance = Math.Round(Pifagor(x1, y1, x2, y2, z1, z2),2);
System.Console.WriteLine($"Расстояние между первой точкой  и  второй точкой в 3D прострастве равно {distance}"); 

