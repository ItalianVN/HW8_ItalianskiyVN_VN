/*  Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07   */

//Вывод массива на экран
void PrintMatrix(int[,] matrix)
{
    string[,] result = new string[matrix.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            result[i, j] = string.Format("{0:d2}", matrix[i, j]);
            Console.Write($"{result[i, j]} ");
        }
        Console.WriteLine();
    }
}

//Вывод массива по спирали
int[,] SpiralMatrix(int m)
{
    int[,] resultMatrix = new int[m, m];

    int a = 0, b = 1, c = 2, k = 1;
    for (int i = 0; i < m; i++)
    {
        for (int j = a; j < m - a; j++)
        {
            resultMatrix[a, j] = k;
            k++;
        }
        for (int j = b; j < m - a; j++)
        {
            resultMatrix[j, m - b] = k;
            k++;
        }
        for (int j = m - c; j >= a; j--)
        {
            resultMatrix[m - b, j] = k;
            k++;
        }
        for (int j = m - c; j > a; j--)
        {
            resultMatrix[j, a] = k;
            k++;
        }
        a++;
        b++;
        c++;
    }
    return resultMatrix;
}


int[,] spiralMatrix = SpiralMatrix(4);
Console.WriteLine("Массив по спирали:");
Console.WriteLine();
PrintMatrix(spiralMatrix);