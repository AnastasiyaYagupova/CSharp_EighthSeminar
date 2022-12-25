/*
Задача 4*. Сформируйте двухмерный массив из неповторяющихся случайных двузначных чисел. 
Напишите программу, которая будет построчно выводить массив. Обратите внимание, 
что максимальный размер такого массива ограничен. Проверку эл-та на присутствие в массиве можно вынести в отдельную функцию.
Например,
11 22 78
12 47 96
25 87 88
*/

Console.WriteLine("Введите количество срок ");
int i = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество стобцов ");
int j = Convert.ToInt32(Console.ReadLine());

void FillArray(int [,] collection)
{
Random rand = new Random();
    for (int i = 0; i < collection.GetLength(0) ; i++)
    {
        for(int j = 0; j < collection.GetLength(1); j++)
        {
        collection[i,j] = rand.Next(10,100);
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


int ReplacingIdenticalNumbers(int [,] collection, int i, int j)
{
Random rand = new Random();
for(int indexLines = 0; indexLines < collection.GetLength(0); indexLines++) 
    {
    for(int indexColumne = 0; indexColumne < collection.GetLength(1); indexColumne++) 
        {
            if(collection[i,j] == collection[indexLines,indexColumne])
                {
                    if(indexLines == i & indexColumne == j)
                        {
                            continue;
                        }
                        else
                        {
                            collection[i,j] = rand.Next(10,100);
                            ReplacingIdenticalNumbers(collection, i, j);
                        }
                }
            else
                {
                    continue;
                }
        }
    }
        return collection[i,j];
} 

int [,] Array = new int[i,j];
FillArray(Array);

if(i*j<=90) // Условие созданно, исходя из задания "Обратите внимание, что максимальный размер такого массива ограничен."
{
for (i = 0; i < Array.GetLength(0); i++)
    {
        for (j = 0; j < Array.GetLength(1); j++)
        {
           int z = ReplacingIdenticalNumbers(Array, i, j);
           Array[i,j] = z;
        }
    }

    PrintArray(Array);
}
else
{
    Console.WriteLine("Невозможно занести в массив более 90 разных чисел");
}