// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void GetAverage0(int[,] Array)
{
    double Sum = 0;
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        Sum = Sum + Array[i, 0];
    }
    System.Console.Write("Среднее арифметическое каждого столбца: " + Math.Round((Sum/3),1));
}

void GetAverage1(int[,] Array)
{
    double Sum = 0;
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        Sum = Sum + Array[i, 1];
    }
    System.Console.Write(" , " + Math.Round((Sum/3),1));
}

void GetAverage2(int[,] Array)
{
    double Sum = 0;
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        Sum = Sum + Array[i, 2];
    }
    System.Console.Write(",  " + Math.Round((Sum/3),1));
}

void GetAverage3(int[,] Array)
{
    double Sum = 0;
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        Sum = Sum + Array[i, 3];
    }
    System.Console.Write(",  " + Math.Round((Sum/3),1));
}

int [,] CreateArray (int length1, int lenght2)
{
    int [,] Array = new int [length1, lenght2];
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
           Array[i,j] = new Random().Next(0, 10);
        }
    }
    return Array;
}

void PrintArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
           System.Console.Write(Array[i,j]+" ");
           
        }
        System.Console.WriteLine();
    }
}

int [,] array = CreateArray(3,4);
PrintArray(array);
GetAverage0(array);
GetAverage1(array);
GetAverage2(array);
GetAverage3(array);