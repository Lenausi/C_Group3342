// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int [,] SquareMatrixs(int [,] matrixA , int [,] matrixB)
{
    int [,] matrixResult = new int[matrixA.GetLength(0), matrixA.GetLength(1)];
    if (matrixA.GetLength(0)== matrixA.GetLength(1) && matrixB.GetLength(0)== matrixB.GetLength(1))
    {for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        for (int k = 0; k < matrixB.GetLength(0); k++)
        {
            matrixResult[i,j] += matrixA[i,k]*matrixB[k,j];
        }
    } 
     
}
return matrixResult;  
}

int[,] matrix1 = CreateMatrixRndInt(2, 2, 0, 5);
System.Console.WriteLine("Матрица №1:");
PrintMatrix(matrix1);

int[,] matrix2 = CreateMatrixRndInt(2, 2, 0, 5);
System.Console.WriteLine("Матрица №2:");
PrintMatrix(matrix2);
System.Console.WriteLine("Результат пермножения двух матриц:");
int[,] matrixResult = SquareMatrixs(matrix1,matrix2);
PrintMatrix(matrixResult);