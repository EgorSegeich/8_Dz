/*
Задача 4*. Сформируйте двухмерный массив из неповторяющихся случайных двузначных чисел. 
Напишите программу, которая будет построчно выводить массив. 
Обратите внимание, что максимальный размер такого массива ограничен. 
Проверку эл-та на присутствие в массиве можно вынести в отдельную функцию.

Например,
11 22 78
12 47 96
25 87 88
*/

Console.WriteLine("введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());


int[,] arr = new int[m, n];

int metod(int i, int j)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            int element = new Random().Next(10, 99);

            {

            }
            arr[i, j] = new Random().Next(10, 99);

            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}
