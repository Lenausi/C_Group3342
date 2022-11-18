// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] CreateArrayRndInt(int size)
{
int[] array = new int[size];
Random rnd = new Random();
for (int i = 0; i < size; i++)
{
array[i] = rnd.Next(-100, 100);
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

// int SumElementsOnOddIndex (int [] array)
// {
//     int sum = default;
//     for (int i = 1; i < array.Length; i=i+2)
//     {
//        sum  = sum + array [i];
//     }
//     return sum;
// }

int SumElementsOnOddIndex (int [] array)
{
    int sum = default;
    for (int i = 0; i < array.Length; i=i+2)
    {
       sum  = sum + array [i];
    }
    return sum;
}

int[] createArrayRndInt = CreateArrayRndInt (4);
PrintArray(createArrayRndInt);
int result = SumElementsOnOddIndex(createArrayRndInt);
System.Console.WriteLine($"Сумма элементов на нечетных позициях равна {result}");