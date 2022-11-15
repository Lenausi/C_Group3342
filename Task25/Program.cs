// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());

int Expo (int a, int b)
{
    int expo = a;
    for (int i = 2; i <=b; i++)
    {
        expo *=a;
    }
    return expo;
}

int result = Expo (num1, num2);
System.Console.WriteLine($"{num1}, {num2} -> {result}");
