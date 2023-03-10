/*
Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с 
наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int[,] array = new int[4, 4] {
{1,2,3,4},
{5,83,6,54},
{23,11,22,13},
{0,1,5,0},
};
int[] array2 = new int[4];
int minSum = 9999;
int row = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    int sum = 0;

    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum = sum + array[i, j];
    }
    array2[i] = sum;

    if (sum < minSum)
    {
        minSum = sum;
        row = i + 1;
    }
}
Console.WriteLine("строка c наименьшей суммой: " + row);