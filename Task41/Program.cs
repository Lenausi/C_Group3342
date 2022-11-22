// Задача 41: Пользователь вводит с клавиатуры M чисел.
//  Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Укажите кол-во чисел для ввода:");  
int m = Convert.ToInt32(Console.ReadLine() );

int SumPositiveElements (int a)
{
    int sum = default;
    for (int i = 0; i < a; i++)
    { 
        Console.WriteLine("Введите число и нажмите enter:"); 
        int b = Convert.ToInt32(Console.ReadLine());
        if (b>0) sum=sum+1;
    }
    return sum;
    
}

int result = SumPositiveElements(m);
System.Console.WriteLine($"Количество введенных чисел больше 0  равно  {result}");