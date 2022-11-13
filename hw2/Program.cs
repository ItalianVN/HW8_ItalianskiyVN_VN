/*  Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка   */

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

//Нахождение наименьшей суммы
int MinIndex(int[,] array)
{
    int minIndex = 0;
    int min = array.GetLength(1) * 9;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int[] sum = new int[array.GetLength(0)];

        for (int j = 0; j < array.GetLength(1); j++)

        {
            sum[i] = sum[i] + array[i, j];
        }
        if (sum[i] < min)
        {
            min = sum[i];
            minIndex = i + 1;
        }
    }
    return minIndex;
}

int[,] matrix = InitMatrix(5, 4);
Console.WriteLine("Заданный массив:");
Console.WriteLine();
PrintMatrix(matrix);
int minIndex = MinIndex(matrix);
Console.WriteLine($"{minIndex} строка имеет наименьшую сумму элементов");

