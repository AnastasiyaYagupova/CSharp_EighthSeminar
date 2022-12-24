/*
Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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

int LineSum(int [,]collection, int i) // Функция на сумму чисел в строке
{
    int resultat = 0;
    for(int j = 0; j < collection.GetLength(1); j++)
    {
        resultat = resultat + collection[i,j];
    }
    return resultat;
}

int a = 0;
int count = 0;
for(int i = 0; i < Array.GetLength(0); i++) // Цикл на перебор строк
{
    int resultat = LineSum(Array, i);
    if(a == 0)
    {
        a = resultat;
        count = i;
    }
    else if (a > resultat)
    {
        a = resultat;
        count = i;
    }
    else
    {
        continue;
    }
}
count++;
Console.WriteLine($"Наименьшая сумма из всех строк: {a}");
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {count}");