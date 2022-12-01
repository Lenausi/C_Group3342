// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.

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

void ChangeMatrixRndInt(int [,] matrix)
{

for (int j = 0; j < matrix.GetLength(1); j+=2) 
{
for (int i = 0; i < matrix.GetLength(0); i+=2)
{
matrix[i, j] = matrix[i,j] * matrix [i,j];
}
}

}


int[,] array2D = CreateMatrixRndInt(3, 4, 0, 100);
PrintMatrix(array2D);
System.Console.WriteLine();
ChangeMatrixRndInt(array2D);
PrintMatrix(array2D);
