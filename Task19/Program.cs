// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет

// 12821 -> да

// 23432 -> да


Console.WriteLine("Введите пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());


string Palindrome (int a)
{
    
        int dig1 = a/10000;
        int dig2 = a/1000%10;
        int dig4 = a/10%10;
        int dig5 = a%10;
        if (dig1 == dig5 && dig2 == dig4) return "ДА";
        return "нет";
}

if (num>9999 && num <100000)
{
    string res = Palindrome(num);
    System.Console.WriteLine($"{res}");
}
else
{
    System.Console.WriteLine("Введите пятизначное число");
}

//  Решение №2
// string Palindrome (int a)
// {
    
// int b = a/1000;
// int c = a%10*10 +a%100/10;

// if (10000<a && a<100000) 
// if (b==c) return "Да";
// else return "Нет";
// return "ВВЕДЕНО НЕКОРРЕКТНОЕ ЧИСЛО";

// }

// string res = Palindrome(num);
// System.Console.WriteLine(res);