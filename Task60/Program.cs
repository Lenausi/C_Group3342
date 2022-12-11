// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int[ , ,] CreateMatrix3DInt(int rows, int columns, int z, int min, int max)
{
int[, ,] matrix3D = new int[rows, columns, z];
Random rnd = new Random();

for (int i = 0; i < matrix3D.GetLength(0); i++) // 2
{
    for (int j = 0; j < matrix3D.GetLength(1); j++)
        for (int k = 0; k < matrix3D.GetLength(2); k++)
        {
            matrix3D[i, j, k] = rnd.Next(min, max + 1); 
        }

}
return matrix3D;
}

void PrintMatrix(int[, ,] matrix3D)
{
    for (int i = 0; i < matrix3D.GetLength(0); i++)
    for (int j = 0; j < matrix3D.GetLength(1); j++)
    {
        // System.Console.WriteLine($"  {i}, {j}");
        for (int k = 0; k < matrix3D.GetLength(2); k++)
        {
            Console.WriteLine($"{matrix3D[i,j,k]} -> Координаты ({i}, {j}, {k} )");
        }
    }
}   

int[, ,] array3D = CreateMatrix3DInt(2, 2, 2, 0, 5);
System.Console.WriteLine("Таблица:");
PrintMatrix(array3D);