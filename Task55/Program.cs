// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.


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

int [,] ReplaceRowsColumns (int [,] matrix)
{
    int [,] tempMatrix = new int [matrix.GetLength(1),matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        tempMatrix [i,j] = matrix[j,i];
    }
    }
    return tempMatrix;
}

int[,] array2D = CreateMatrixRndInt(3, 4, 0, 5);
if (array2D.GetLength(0)==array2D.GetLength(1))
{
System.Console.WriteLine("Таблица:");
PrintMatrix(array2D);
System.Console.WriteLine();
int [,] replaceRowsColumns = ReplaceRowsColumns(array2D);
PrintMatrix(replaceRowsColumns); 
}

else
{
    System.Console.WriteLine("Исходный массив не является равномерным, невозможно заменить строки на столбцы");
}

