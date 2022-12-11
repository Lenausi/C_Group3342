// Задача 54: Задайте двумерный массив. Напишите программу,
//  которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


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


void MatrixBubbleSortRows(int[,] matrix)
{
    // int temp =0;
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1)-i- 1; j++)
                for (int k = 0; k < matrix.GetLength(1)-1; k++)
                    {
                        if (matrix[i, k] < matrix[i, k + 1])
                    {
                        int temp = matrix[i, k + 1];
                        matrix[i, k + 1] = matrix[i, k];
                        matrix[i, k] = temp;  
                    }
                    }

}

int[,] array2D = CreateMatrixRndInt(2,6 , -10, 10);
System.Console.WriteLine("Таблица:");
PrintMatrix(array2D);
System.Console.WriteLine("Сортированный по убыванию массив");
MatrixBubbleSortRows(array2D);
PrintMatrix(array2D);