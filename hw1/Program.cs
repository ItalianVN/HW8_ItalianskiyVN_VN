/*   Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2   */


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

//Упорядочить элементы в строках
int[,] NewMatrix(int[,] array)
{
    int[,] resultArray = new int[array.GetLength(0), array.GetLength(1)];

    for (int i = 0; i < array.GetLength(0); i++)
    {

        int[] intArray = new int[array.GetLength(1)];

        for (int j = 0; j < array.GetLength(1); j++)

        {
            intArray[j] = array[i, j];
        }
        Array.Sort(intArray);
        Array.Reverse(intArray);
        for (int k = 0; k < array.GetLength(1); k++)

        {
            resultArray[i, k] = intArray[k];
        }


    }
    return resultArray;
}

int[,] matrix = InitMatrix(4, 4);
Console.WriteLine("Исходный массив:");
Console.WriteLine();
PrintMatrix(matrix);
Console.WriteLine();
Console.WriteLine("Отсортированный массив:");
Console.WriteLine();
int[,] newMatrix = NewMatrix(matrix);
PrintMatrix(newMatrix);
