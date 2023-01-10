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


int FindRepeat(int[,] array, int rndNumber)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == rndNumber) rndNumber = 0;
        }
    }
    return rndNumber;
}


Console.WriteLine("введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());


int[,] arr = new int[n, m];
Random rnd = new Random();

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        int num = rnd.Next(10, 99);
        {
            int rndNum = rnd.Next(10, 99);
            rndNum = FindRepeat(arr, rndNum);
            if (rndNum == 0) j--;
            else arr[i, j] = rndNum;
        }
    }
}

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
}