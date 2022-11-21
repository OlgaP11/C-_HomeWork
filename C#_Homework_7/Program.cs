// Задайте двумерный массив размером m*n, заполненный случайными вещественными числами.

/*double [,] Create2DArray ()
{
    Console.Write ("input quantity of rows: ");
    int rows = Convert.ToInt32 (Console.ReadLine ());
    Console.Write ("input quantity of columns: ");
    int columns = Convert.ToInt32 (Console.ReadLine ());
    Console.Write ("input min value of array: ");
    int minVal = Convert.ToInt32 (Console.ReadLine ());
    Console.Write ("input max value of array: ");
    int maxVal = Convert.ToInt32 (Console.ReadLine ());

    double [,] createdArray = new double [rows, columns];

    for (int i =0; i < rows; i++)
    {
        for (int j =0; j < columns; j++)
        {
            createdArray [i,j] = new Random().Next (minVal, maxVal + 1);
            createdArray [i,j] += Math.Round (new Random().NextDouble(), 1);
        }
    }
    return createdArray;
}

void Show2DArray (double [,] array)
{
    for (int i =0; i < array.GetLength(0); i++)
    {
        for (int j =0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array [i, j]} ");
        }
        Console.WriteLine();
    }
}

double [,] userArray = Create2DArray ();
Show2DArray (userArray);*/

// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве
// и возвращает значение этого элемента или же указание, что такого элемента нет.

/*int [,] Create2DArray ()
{
    Console.Write ("input quantity of rows: ");
    int rows = Convert.ToInt32 (Console.ReadLine ());
    Console.Write ("input quantity of columns: ");
    int columns = Convert.ToInt32 (Console.ReadLine ());

    int [,] createdArray = new int [rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j =0; j < columns; j++)
        {
            createdArray [i,j] = new Random().Next (-99, 100);
        }
    }
    return createdArray;
}

void Show2DArray (int [,] array)
{
    for (int i =0; i < array.GetLength(0); i++)
    {
        for (int j =0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array [i, j]} ");
        }
        Console.WriteLine();
    }
}

void FindElement (int [,] array)
{
    Console.Write ("Input row's index: ");
    int rowIndex = Convert.ToInt32 (Console.ReadLine());
    Console.Write ("Input column's index: ");
    int colIndex = Convert.ToInt32 (Console.ReadLine());

    if (0 < rowIndex & rowIndex < array.GetLength(0) & 0 < colIndex & colIndex < array.GetLength(1))
    {
       Console.WriteLine ($"Quantity of element is {array[rowIndex, colIndex]}"); 
    }
    else Console.WriteLine ($"Sorry, there isn't an element with those indexes.");
}

int [,] newArray = Create2DArray ();
Console.WriteLine();
Show2DArray (newArray);
Console.WriteLine();
FindElement (newArray);*/

// Задайте двумерный массив из целых чисел. Найдите среднеарифметическое в каждом столбце.

/*int [,] Create2DArray ()
{
    Console.Write ("input quantity of rows: ");
    int rows = Convert.ToInt32 (Console.ReadLine ());
    Console.Write ("input quantity of columns: ");
    int columns = Convert.ToInt32 (Console.ReadLine ());

    int [,] createdArray = new int [rows, columns];

    for (int i =0; i < rows; i++)
    {
        for (int j =0; j < columns; j++)
        {
            createdArray [i,j] = new Random().Next (1, 10);
        }
    }
    return createdArray;
}

void Show2DArray (int [,] array)
{
    for (int i =0; i < array.GetLength(0); i++)
    {
        for (int j =0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array [i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

double [] FindAverageOfColumns (int [,] array)
{
    int size = array.GetLength (1);
    double [] averageInCol = new double [size];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            averageInCol [j] += array [i, j];  
        }   
        averageInCol [j] = Math.Round (averageInCol [j] / averageInCol.Length, 1);   
    }
    return averageInCol;
}

void ShowArray (double [] array)
{
    for (int i =0; i < array.Length; i++)
    {
       Console.Write($"{array [i]}; ");
    }
    Console.WriteLine ("\b\b.");
}

int [,] newArray = Create2DArray ();
Show2DArray (newArray);

double [] newAverageInCol = FindAverageOfColumns (newArray);
Console.Write ("The sum of elements in each column of array is ");
ShowArray (newAverageInCol);*/