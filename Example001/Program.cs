/*
Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

void FillArray(int [,] collection)
{
Random rand = new Random();
    for (int i = 0; i < collection.GetLength(0) ; i++)
    {
        for(int j = 0; j < collection.GetLength(1); j++)
        {
        collection[i,j] = rand.Next(1,10);
        }
    }
} 

void PrintArray(int [,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            Console.Write(collection[i,j] + "|");
        }
        Console.WriteLine();
    }
}

int [,] Array = new int [4,4];
FillArray(Array);
PrintArray(Array);

for(int i = 0; i < Array.GetLength(0); i++)
{
    for(int j = 0; j < Array.GetLength(1); j++)
    {
        for(int b = 0; b < Array.GetLength(1); b++)
        {
            int temp = 0;
            if(Array[i,j] > Array[i,b])
            {
                temp = Array[i,j];
                Array[i,j] = Array[i,b];
                Array[i,b] = temp;
            }
            else
            {
                continue;
            }
        }
    }
}
Console.WriteLine();
PrintArray(Array);