// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
int[,] matrix = new int[rows, columns];
Random rnd = new Random();

for (int j = 0; j < matrix.GetLength(1); j++)
{
for (int i = 0; i < matrix.GetLength(0); i++)
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

double [] FindAverageColumns(int [,] matrix)
{ 
    double sum = default;
    double [] array = new double [matrix.GetLength(1)];

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum+=matrix[i,j];
        }  
        double averageColumn = sum/matrix.GetLength(0);
        array[j]= Math.Round(averageColumn,1); 
        sum=0;
    }
    return array;
}

void PrintArray (double[] array)
{
Console.Write("|");
for (int i = 0; i < array.Length; i++)
{
if(i < array.Length - 1) Console.Write($"{array[i],5} |");
else Console.Write($"{array[i],5} ");
}
Console.WriteLine("|");
}
    



int[,] array2D = CreateMatrixRndInt(3, 4, 0, 5);
System.Console.WriteLine("Таблица:");
PrintMatrix(array2D);
double [] findAverageColumns = FindAverageColumns(array2D);
System.Console.WriteLine("Среднее арифметическое элементов каждого столбца:");
PrintArray(findAverageColumns);
