// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.WriteLine("Введите количество элементов массива : ");
int num = Convert.ToInt32(Console.ReadLine());


int[] NewArray (int size)
{
int[] array = new int[size];
Random rnd = new Random();
for (int i = 0; i < array.Length; i++)
{
array[i] = rnd.Next(1,100);
}
return array;
}

void PrintArray(int[] array)
{
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
Console.Write(array[i]);
if (i<array.Length-1) Console.Write(",");
}
Console.Write("]");
}

int[] nameArray = NewArray(num);
PrintArray(nameArray);