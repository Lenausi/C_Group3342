// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
int[,] matrix = new int[rows, columns];
Random rnd = new Random();

for (int j = 0; j < matrix.GetLength(1); j++) // 2
{
for (int i = 0; i < matrix.GetLength(0); i++) //
{
matrix[i, j] = rnd.Next(min, max + 1); 
}

}
return matrix;
}

void PrintMatrix(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
Console.Write("|");
for (int j = 0; j < matrix.GetLength(1); j++)
{
if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i,j], 5} |");
else Console.Write($"{matrix[i,j], 5}");
}
Console.WriteLine(" |");
}
}

int [] ArrayFromMatrix (int [,] matrix)
{
int count  = 0;
int [] arrayFromMatrix  = new int [matrix.GetLength(0)*matrix.GetLength(1)];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        arrayFromMatrix[count] = matrix[i,j];
        count++;
    }
}
 return arrayFromMatrix;
}


void PrintArray(int[] array)
{
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
if(i < array.Length - 1) Console.Write($"{array[i]},");
else Console.Write($"{array[i]}");
}
Console.WriteLine("]");
}

void CountNumbers (int [] array)
{
    int count  = 0; 
    int elem = array[0];
    for (int i = 0; i < array.Length; i++)
    {
       if(elem == array[i]) count ++;
       else
       {
        System.Console.WriteLine($"Элементов {elem} => {count}");
        elem = array [i];
        count = 1;
       }
    }
    System.Console.WriteLine($"Элементов {elem} => {count}");
}


int[,] array2D = CreateMatrixRndInt(3, 4, 0, 5);
System.Console.WriteLine("Таблица:");
PrintMatrix(array2D);
int [] array =ArrayFromMatrix(array2D);
Array.Sort(array);
System.Console.WriteLine();
System.Console.WriteLine("Сортированный одномерный массив:");
PrintArray(array);
System.Console.WriteLine();
CountNumbers(array);


