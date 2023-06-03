// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)
int[,,] array = new int[2, 2, 2];
if (array.GetLength(0)*array.GetLength(1)*array.GetLength(2)>=89){//ограничение диапазона 
    Console.WriteLine("Out of range");
    return;
}
Random rand = new Random();// создание объекта для генерации случайных чисел
int[] page = new int [array.GetLength(0)*array.GetLength(1)*array.GetLength(2)];

for (int m = 0; m<array.GetLength(0)*array.GetLength(1)*array.GetLength(2); m++)// заполнение массива случайными неповторяющимися числами
{
    int randomNumber = 0;
    bool containsNumber = true;
    do
    {
        randomNumber = rand.Next(10,99); //генератор случайных чисел
        containsNumber = Array.IndexOf(page, randomNumber)!=-1;//проверка массива на содержание числа
    }
    while (containsNumber);// ессли число не содержится в массиве,
    page[m] = randomNumber;// добавляем его в массив
}
void PrintArray (int [,,] arr){
int count = 0;
for (int k = 0; k<arr.GetLength(0); k++)
{
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        for (int j = 0; j < arr.GetLength(2); j++)
        {
            arr[k, i, j] = page[count];
            count = count+1;
            Console.Write($" {arr[k,i,j]} ({i},{j},{k})");
        }
        Console.WriteLine();
    }
}
}
PrintArray(array);
Console.WriteLine();