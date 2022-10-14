// . Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8
Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num<1000 && num>100)
{
   int result = num% 10;System.Console.WriteLine($"Последняя цифра введенного числа {result}");
}
else
System.Console.WriteLine("Ошибка! Введите трехзначное число");