/*Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит 
по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int[,] array = new int[3, 4] {
{5,2,3,4},
{5,4,6,7},
{5,1,2,7}
};

int temp = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(0); j++)
        if (array[i, j] > array[i, j + 1])
        {
            temp = array[i, j];
            array[i, j] = array[i, j + 1];
            array[i, j + 1] = temp;
        }
}

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
