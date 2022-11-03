// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

void Square (int x)

{
    if (x>0)
    {
    for (int i = 1; i <= x; i++)
    {
        System.Console.WriteLine($"{i} -> {i*i*i}");
    }
    }
    else
    {
        System.Console.WriteLine("Введите значение больше 0");
    }
}

Square (num);