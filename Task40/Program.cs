// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.WriteLine("Введите первое число :");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число :");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число :");
int num3 = Convert.ToInt32(Console.ReadLine());

bool IsExsistTriangle (int a,int b, int c)
{
if (a<b+c && b<c+a && c <a+b)
{
    return true;
}

else return false;
}

bool result = IsExsistTriangle(num1, num2, num3);
Console.WriteLine(result);