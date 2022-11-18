// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

int [] CreateArrayInt (int size)
{
    int [] array  = new int [size];
    Random rnd = new Random ();
    for (int i  = 0; i < array.Length; i++)
    {
        array [i] = rnd.Next(-10,10);
    }
    return array;
}



void PrintArray (int [] array)
{
 Console.Write ("[");
 for (int i = 0; i < array.Length; i++)
 {
if(i < array.Length - 1) Console.Write($"{array[i]},");
else Console.Write($"{array[i]}");
 }
 Console.Write ("]");
}

int [] FindDigInArray (int [] arrayB, int a)
{
    for (int i = 0; i < arrayB.Length; i++)
    {
     if (arrayB[i]==a)
    {
     System.Console.WriteLine("В заданном массиве есть искомое число");;
    }
    break;
   
} 
return arrayB ;
}

int [] createArrayInt = CreateArrayInt(5);
PrintArray(createArrayInt);

Console.WriteLine ("Задайте число для поиска в массиве: ");
int num = Convert.ToInt32(Console.ReadLine());
FindDigInArray(createArrayInt, num);


// Правильный вариант bool

// bool FindNUmArray(int[] array, int num)
// {
// for (int i = 0; i < array.Length; i++)
// {
// if (array[i] == num) return true;
// }

// return false;
// }

// Console.WriteLine("Введите искомое число");
// int number = Convert.ToInt32(Console.ReadLine());
// int[] arr = RndMass(12, -9, 9);
// PrintArray(arr);

// if (FindNUmArray(arr, number))
// {
// Console.WriteLine("Да");
// }
// else
// {
// Console.WriteLine("Нет");
// }


// Второе решение правильное через bool
// bool Find(int[] array, int find1)
// {
// bool b = false;
// for (int i = 0; i < array.Length; i++)
// {
// if (array[i] == find1)
// {
// b = true;
// break;
// }
// }
// return b;
// }

