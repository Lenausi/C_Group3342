// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

void Square (int x)

{
    if (x>0)
    {
    for (int i = 1; i <= x; i++)
    {
        System.Console.WriteLine($"{i} -> {i*i}");
    }
    }
    else
    {
        System.Console.WriteLine("Введите значение больше 0");
    }
}

Square (num);