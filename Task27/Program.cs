// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int SumofDig (int a)
{
    int sum = default;
    int numofdig = Convert.ToString(a).Length;

    for (int i = 0; i < numofdig; i++)
    {
        
        sum = sum +a%10;
        a = a/10;
       
    }

  return sum;
}

int res = SumofDig (num);
System.Console.WriteLine($"{res}");