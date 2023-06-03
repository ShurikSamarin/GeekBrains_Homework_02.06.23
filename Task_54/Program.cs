// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
int[,] GetArray(int row, int col, int valueMin, int valueMax)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(valueMin, valueMax);
        }
    }

    return array;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]} ");
        }
        Console.WriteLine();
    }
}
void SortArray(int[,] inArray)//перестановка элементов массива от минимального к максимальному
{   
    for(int m = 0; m < inArray.GetLength(0); m++)
    {
    for (int i = 0; i < inArray.GetLength(1); i++)
    {
        for (int j = i + 1; j < inArray.GetLength(1); j++)
        {
            if (inArray[m,i] < inArray[m,j])
            {
                int k = inArray[m,i];
                inArray[m,i] = inArray[m,j];
                inArray[m,j] = k;
            }
        }
    }
    }
}
Console.Clear();
int[,] myArray = GetArray(7, 8, 0, 10);
PrintArray(myArray);
SortArray(myArray);
Console.WriteLine("");
PrintArray(myArray);
