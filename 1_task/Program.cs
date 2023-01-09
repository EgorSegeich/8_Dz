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
{5,2,3,9},
{5,6,4,7},
{7,1,2,5}
};

int temp = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int max = j;
        for (int l = j + 1; l < array.GetLength(1); l++)
        {
            if (array[i, l] > array[i, max])
            {
                temp = array[i, l];
                array[i, l] = array[i, max];
                array[i, max] = temp;
            }
        }
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}