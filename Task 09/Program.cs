// Найти наибольшую цифру числа в промежутке от  10 до 99



int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 => {number}");

int firstDigit = number / 10; // 78 / 10 = 7
int secondDigit = number % 10; // 78 % 10 = 8

// if(firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа равна {firstDigit}");
// else Console.WriteLine($"Наибольшая цифра числа равна {secondDigit}");

// Условный оператор
int result = default;
if(firstDigit > secondDigit) result = firstDigit;
else result = secondDigit;
Console.WriteLine($"Наибольшая цифра числа равна {result}");
// Тернарный оператор 1
int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
Console.WriteLine($"Наибольшая цифра числа равна {maxDigit}");
// Тернарный оператор 2
Console.Write($"Наибольшая цифра числа {number} равна ");
Console.WriteLine(firstDigit > secondDigit ? firstDigit : secondDigit);