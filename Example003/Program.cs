/*
Задача 3: Задайте две квадратные матрицы одинакового размера. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица:
18 20
15 18
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

int[,] FirstArray = new int[2,2];
int[,] SecondArray = new int[2,2];
FillArray(FirstArray);
FillArray(SecondArray);
PrintArray(FirstArray);
Console.WriteLine();
PrintArray(SecondArray);

void MatrixMultiplication(int[,]collection1, int[,]collection2)
{
    int[,] Array = new int[2,2];
    Array[0,0] = collection1[0,0]*collection2[0,0]+collection1[0,1]*collection2[1,0];
    Console.Write(Array[0,0] + "|");
    Array[0,1] = collection1[0,0]*collection2[0,1]+collection1[0,1]*collection2[1,1];
    Console.Write(Array[0,1] + "|");
    Console.WriteLine();
    Array[1,0] = collection1[1,0]*collection2[0,0]+collection1[1,1]*collection2[1,0];
    Console.Write(Array[1,0] + "|");
    Array[1,1] = collection1[1,0]*collection2[0,1]+collection1[1,1]*collection2[1,1];
    Console.Write(Array[1,1] + "|");
}

Console.WriteLine();
MatrixMultiplication(FirstArray,SecondArray);
