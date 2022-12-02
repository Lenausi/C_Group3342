// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет


// void InputData()
//     {
//         Console.WriteLine("Введите номер строки в таблице:  ");
//         int rows = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine("Введите номер столбца в таблице: ");
//         int columns = Convert.ToInt32(Console.ReadLine()); 
//     }

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
int[,] matrix = new int[rows, columns];
Random rnd = new Random();

for (int j = 0; j < matrix.GetLength(1); j++) // 2
{
for (int i = 0; i < matrix.GetLength(0); i++) //
{
matrix[i, j] = rnd.Next(min, max + 1); // 2 - 3
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

int FindElement (int [,] matrix)
{
Console.WriteLine("Введите номер строки в таблице:  ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца в таблице: ");
int n = Convert.ToInt32(Console.ReadLine()); 
int result = default;
if (m<matrix.GetLength(0)+1 && n<matrix.GetLength(1)+1)
{
    result  = matrix [m-1,n-1];
}
else
{
    System.Console.WriteLine("Введенные параметры не соответсвуют размеру таблицы");
}
return result;
}


int[,] array2D = CreateMatrixRndInt(3, 4, 0, 100);
System.Console.WriteLine("Таблица:");
PrintMatrix(array2D);
int findElement = FindElement(array2D);
System.Console.WriteLine($"Искомый элемент в таблице равен {findElement}");