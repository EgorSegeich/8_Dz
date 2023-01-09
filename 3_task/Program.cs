/*
Задача 3: Задайте две квадратные матрицы одинакового размера. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица:
18 20
15 18
*/


void compositionOfMatrix(int[,] array1, int[,] array2)
{
    int[,] arrayResult = new int[array1.GetLength(1), array2.GetLength(0)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array2.GetLength(0); k++)
            {
                arrayResult[i, j] += array1[i, k] * array2[k, j];
            }
            Console.Write(arrayResult[i, j] + " ");
        }
        Console.WriteLine();
    }
}


int[,] array3 = new int[3, 3] {
{1,3,5},
{2,4,6},
{3,1,5},
};

int[,] array4 = new int[3, 3] {
{2,6,4},
{5,1,3},
{5,3,1}
};

compositionOfMatrix(array3, array4);