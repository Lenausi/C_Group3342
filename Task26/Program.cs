// 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5


Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int NumDig (int number)
{
int count  = 0;
 while (number>0)
    {
        number = number/10;
        count ++;
    }
    return count > 0 ? count :1 ;
}

int result = NumDig (num);
System.Console.WriteLine($"Кол-во цифр в числе {num} равно {result}");