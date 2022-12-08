// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

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


int FindIndexMinArray (int [] array)
{ 
    int min = array[0];
    int index = 0;
        for (int i = 0; i <= array.Length-1; i++)
        {
            if  (array[i] < min)
                {
                    min = array[i];
                    index=i;
                }
            
        }
    return index;
}

int FindMinRawSum (int [,] matrix)
{ 

    int sum = default;
    int [] array = new int [matrix.GetLength(0)];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum+=matrix[i,j];
                }  
        array[i]=sum; 
        sum=0;
        }
    int result = FindIndexMinArray(array);
    return result;
}



int[,] array2D = CreateMatrixRndInt(3, 4, 0, 5);
System.Console.WriteLine("Таблица:");
PrintMatrix(array2D);
int findMinArraySum = FindMinRawSum(array2D);
System.Console.WriteLine($"Строка c наименьшей суммой:{findMinArraySum+1}");
