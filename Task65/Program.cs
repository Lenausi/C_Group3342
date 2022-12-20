// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

Console.WriteLine("Введите натуральное число М: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число N: ");
int num2 = Convert.ToInt32(Console.ReadLine());

void NaturalNumbers (int m, int n)
{
    if (m<n) 
    {
        System.Console.WriteLine($"{m}");
        NaturalNumbers(m+1,n);
    }    
  
    if (m>n) 
    {
        System.Console.WriteLine($"{m}");
        NaturalNumbers(m-1,n);
    }
    
    if (m==n)
    {
        System.Console.WriteLine($"{m}");
    }
}

NaturalNumbers(num1,num2);
