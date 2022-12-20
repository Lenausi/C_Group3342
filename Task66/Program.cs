// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите натуральное число М: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число N: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int NaturalNumbers (int m, int n)

{
    int sum = m;
    if (m<n)
    {
     sum += NaturalNumbers(m+1, n);
    }
    
    if (m>n)
    {
     sum += NaturalNumbers(m-1, n);
    }

    return sum;

}

int result = NaturalNumbers(num1, num2);
System.Console.WriteLine($"  М ({num1}), N ({num2}) ->  {result}");