// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


int[] CreateArrayRndInt(int size)
{
int[] array = new int[size];
Random rnd = new Random();
for (int i = 0; i < size; i++)
{
array[i] = rnd.Next(100, 999);
}
return array;
}


void PrintArray (int[] array)
{
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
if(i < array.Length - 1) Console.Write($"{array[i]},");
else Console.Write($"{array[i]}");
}
Console.WriteLine("]");
}

int NumberEvenDig (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
     if (array[i]%2 == 0) count++;
    }
    return count;
}



int [] createArrayRndInt = CreateArrayRndInt (5);
PrintArray(createArrayRndInt);
int result = NumberEvenDig(createArrayRndInt);
System.Console.WriteLine($"Количество четных чисел в массиве равно {result}");

