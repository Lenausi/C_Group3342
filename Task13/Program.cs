// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num>999)
{
    do
{
    num = num/10;

} 
while (num>999);
int result = num%10;
Console.WriteLine($"{result} ");
}
else if (num>99)
{
    int result = num%10;
    Console.WriteLine($"{result}");
}
else
{Console.WriteLine($"Третьей цифры нет");}


