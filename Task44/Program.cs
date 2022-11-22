// Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] FibonacciN(int num)
{
int[] arrayFibonacci = new int[num];
arrayFibonacci[1] = 1;
for (int i = 2; i < num; i++)
{
arrayFibonacci[i] = arrayFibonacci[i - 1] + arrayFibonacci[i - 2];
}
return arrayFibonacci;
}

void PrintArray(int[] array)
{
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
if (i < array.Length - 1) Console.Write($"{array[i]},");
else Console.Write($"{array[i]}");
}
Console.WriteLine("]");
}

int[] fibonacciArray = FibonacciN(number);
PrintArray(fibonacciArray);