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

int[,] array = new int[2, 2] {
{1,3},
{2,4},
};

int[,] array2 = new int[2, 2] {
{3,2},
{4,1},
};

int[,] arrayResult = new int[2, 2];

 for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    for (int k = 0; k < array2.GetLength(0); k++)
                    {
                        arrayResult[i,j] += array[i,k] * array2[k,j];
                        
                    }
                Console.Write(arrayResult[i, j]);
                }
            }



/*
arrayResult[0, 0] = array[0, 0] * array2[0, 0] + array[0, 1] * array2[1, 0];

Console.WriteLine(arrayResult[0, 0]);

arrayResult[0, 1] = array[0, 0] * array2[0, 1] + array[0, 1] * array2[1, 1];

Console.WriteLine(arrayResult[0, 1]);

arrayResult[1, 0] = array[1, 0] * array2[0, 0] + array[1, 1] * array2[1, 0];

Console.WriteLine(arrayResult[1, 0]);

arrayResult[1, 1] = array[1, 0] * array2[0, 1] + array[1, 1] * array2[1, 1];

Console.WriteLine(arrayResult[1, 1]);
*/
