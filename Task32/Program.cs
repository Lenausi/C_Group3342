// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]



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

int [] ChangeMathSignInArray (int[] array)
{
   int[] newArray = new int [array.Length]; 
    for (int i = 0; i < array.Length; i++)
    {
        newArray [i] = array [i]* -1;
    }
    return newArray;
}

void PrintArray (int [] array)
{
 Console.Write ("[");
 for (int i = 0; i < array.Length; i++)
 {
//    i<(array.Length-1) ? Console.Write ($"{array [i]},") : Console.Write($"{array[i]} ");
if(i < array.Length - 1) Console.Write($"{array[i]},");
else Console.Write($"{array[i]}");
 }
 Console.Write ("]");
}

int[] arr = CreateArrayInt(4);
PrintArray(arr);


// int[] changeMathSignInArray = ChangeMathSignInArray(arr);
// PrintArray(changeMathSignInArray);

int[] changedArray = ChangeMathSignInArray (arr); 
PrintArray(changedArray);