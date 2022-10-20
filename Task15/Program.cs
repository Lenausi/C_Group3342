// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


Console.WriteLine("Введите число от 1 до 7: ");
int num = Convert.ToInt32(Console.ReadLine());

if (0>num || num>7)
{
    System.Console.WriteLine("Повторите ввод от 1 до 7");
}
else if (num==1)
{
    System.Console.WriteLine("ПН, нет");
}
else if (num==2)
{
   System.Console.WriteLine("ВТ, нет"); 
}
else if (num==3)
{
   System.Console.WriteLine("СР, нет"); 
}
else if (num==4)
{
   System.Console.WriteLine("ЧТ, нет"); 
}
else if (num==5)
{
   System.Console.WriteLine("ПТ, нет"); 
}
else if (num==6)
{
   System.Console.WriteLine("СБ, ДА"); 
}
else if (num==7)
{
   System.Console.WriteLine("ВС, ДА"); 
}