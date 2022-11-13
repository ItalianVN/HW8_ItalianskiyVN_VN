/*  Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)    */

int[,,] InitMatrix(int l, int m, int n)
{
    int[,,] resultMatrix = new int[l, m, n];
    Random rnd = new Random();

    for (int i = 0; i < l; i++)
    {
        for (int j = 0; j < m; j++)
        {
            for (int k = 0; k < n; k++)
            {
                resultMatrix[i, j, k] = rnd.Next(10, 100);
            }
        }
    }
    return resultMatrix;
}

//Вывод массива на экран
void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]} ({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

int[,,] matrix = InitMatrix(2, 2, 2);
Console.WriteLine("Заданный массив:");
Console.WriteLine();
PrintMatrix(matrix);