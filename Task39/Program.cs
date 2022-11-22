// Задача 39: Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int[] CreateArrayRndInt(int size, int min, int max)
{
int[] array = new int[size];
Random rnd = new Random();
for (int i = 0; i < size; i++)
{
array[i] = rnd.Next(min, max + 1);
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


void ReverseArray(int[] array)
{
for (int i = 0; i < array.Length / 2; i++) //2
{
int temp = array[i]; //2
array[i] = array[array.Length - 1-i];
array[array.Length - 1-i ] = temp;
}
}

int[] arr = CreateArrayRndInt(5, 1, 9);
PrintArray(arr);
// Array.Reverse(arr);
// PrintArray(arr);
ReverseArray(arr);
PrintArray(arr);
