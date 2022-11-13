/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18    */

//Формирование массива
int[,] InitMatrix(int m, int n)
{
    int[,] resultMatrix = new int[m, n];
    Random rnd = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            resultMatrix[i, j] = rnd.Next(1, 10);
        }
    }
    return resultMatrix;
}

//Вывод массива на экран
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

//Произведение двух матриц
int[,] NewMatrix(int[,] array1, int[,] array2)
{
    var resultArray = new int[array1.GetLength(0), array2.GetLength(1)];
    if (array1.GetLength(1) == array2.GetLength(0))
    {
        for (int i = 0; i < resultArray.GetLength(0); i++)
        {
            for (int j = 0; j < resultArray.GetLength(1); j++)
            {
                resultArray[i, j] = 0;
                for (int n = 0; n < array1.GetLength(1); n++)
                {
                    resultArray[i, j] += array1[i, n] * array2[n, j];
                }
            }
        }
    }
    else
        Console.WriteLine("Длина строки первой матрице не равна длине столбца второй матрицы");
    return resultArray;
}

int[,] matrix1 = InitMatrix(3, 3);
Console.WriteLine("Первая матрица:");
PrintMatrix(matrix1);
Console.WriteLine();
int[,] matrix2 = InitMatrix(3, 3);
Console.WriteLine("Вторая матрица:");
PrintMatrix(matrix2);
Console.WriteLine();
Console.WriteLine("Матрица в результате произведения двух вышеперечисленных матриц равна:");
int[,] newMatrix = NewMatrix(matrix1, matrix2);
PrintMatrix(newMatrix);
