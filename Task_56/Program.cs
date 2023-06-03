// See https://aka.ms/new-console-template for more information
//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Console.WriteLine("Input rows: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Input columns: ");
int columns = int.Parse(Console.ReadLine());
int[,] GetArray(int rows, int columns,int minValue,int maxValue)
{
    int[,] result = new int[rows, columns];
    for(int i =0;i < rows;i++)
    {
        for (int j = 0; j < columns;j++)
        {
            result[i, j] = new Random().Next(minValue,maxValue);
            Console.Write($"{result[i,j]} ");
        }
        Console.WriteLine();
    }
    return result;
}
Console.WriteLine("");
Console.WriteLine("Array: ");
int[,] array = GetArray(rows, columns,1,10);
Console.WriteLine("");
Console.WriteLine("Sums of rows are:");
void Sum(int[,] arr)
{   
    int[] sums = new int [arr.GetLength(0)];
    for(int i =0; i < arr.GetLength(0);i++)
    {
        int result = 0;
        for (int j = 0; j < arr.GetLength(1);j++)
        {
            result = result + arr[i,j];
        }
        sums [i] = result;
        Console.Write($" {sums[i]}");
    }
    Console.WriteLine("");
    int minimum = sums[0];
    int index = 0;
    for (int m = 0; m < sums.Length; m++) {
        if (sums[m] < minimum) index = m;
    }
    Console.WriteLine($"Minimum sum is in row {index+1}");
}

Sum(array);



