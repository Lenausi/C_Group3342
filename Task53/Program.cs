// Pадача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.


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

void ReplaceRows (int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
       int temp = matrix [0,i];
       matrix [0,i] = matrix[matrix.GetLength(0)-1,i];
       matrix[matrix.GetLength(0)-1,i] = temp;
    
    }
}
int[,] array2D = CreateMatrixRndInt(3, 4, 0, 5);
System.Console.WriteLine("Таблица:");
PrintMatrix(array2D);
System.Console.WriteLine();
ReplaceRows(array2D);
PrintMatrix(array2D);


