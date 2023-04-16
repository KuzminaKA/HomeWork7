// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int Read(string arg)
{
    System.Console.Write($"введите {arg}: ");
    int result=int.Parse(Console.ReadLine());
    return result;
}


void FindNumber(int index1, int index2, int [,] Array)
{   
    if (index1 > Array.GetLength(0) || index2 > Array.GetLength(1))
    {
        System.Console.WriteLine("такого числа в массиве нет!");
    }
    else
    {int number = Array[index1,index2];
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
           if(i==index1 && j==index2)
           {
            number=Array[i,j];
           }
                                        
        }
    }
    System.Console.WriteLine($"значение элемента - {number}");
    }

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

int index1 = Read($"индекс 1");
int index2= Read($"индекс 2");
int [,] array = CreateArray(4,4);
PrintArray(array);
FindNumber(index1, index2, array);