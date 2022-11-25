// Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

/*int [,] CreateMatrix ()
{
    Console.Write ("Input number of rows: ");
    int rows = Convert.ToInt32 (Console.ReadLine ());
    Console.Write ("Input number of columns: ");
    int columns = Convert.ToInt32 (Console.ReadLine ());

    int [,] createdMatrix = new int [rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            createdMatrix [i,j] = new Random().Next(1, 10);
        }
    }
    return createdMatrix;
}

void ShowMatrix (int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength (0); i++)
    {
        for (int j = 0; j < matrix.GetLength (1); j++)
        {
            Console.Write (matrix [i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int [,] SortedRowsFromMax (int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength (0); i++)
    {
        for (int j = 0; j < matrix.GetLength (1) -1 ; j++)
        {
            int jMin = j;
            for (int k = j + 1; k < matrix.GetLength (1); k++)
            {
               if (matrix [i, k] > matrix [i, jMin]) jMin = k; 
            }
            int temp = matrix [i, j];
            matrix [i,j] = matrix [i, jMin];
            matrix [i, jMin] = temp;
        }
    }
    return matrix;
}

int [,] newMatrix = CreateMatrix ();
ShowMatrix (newMatrix);
ShowMatrix (SortedRowsFromMax (newMatrix));*/

// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

/*int [,] RectangularMatrix (int rows, int columns)
{
    int [,] createdMatrix = new int [rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            createdMatrix [i,j] = new Random().Next (1,10);
        }
    }
    return createdMatrix;
}

void ShowMatrix (int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength (0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write (matrix [i,j] + " ");
        }
        Console.WriteLine ();
    }
    Console.WriteLine ();
}

void FindSmallestRow (int [,] matrix)
{
    int [] sumInRows = new int [matrix.GetLength (0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumInRows [i] += matrix [i,j];
        }
    }
    int minPosition = 0;
    for (int i = 1; i < sumInRows.Length; i++)
    {
        if (sumInRows [i] < sumInRows [minPosition]) minPosition = i;
    }
    Console.WriteLine ($"The row with the smallest elements' sum is number {minPosition + 1}.");
}



Console.Write ("Input number of rows to creat a rectangular array: ");
int userRows = Convert.ToInt32 (Console.ReadLine ());
Console.Write ("Input number of columns: ");
int userColumns = Convert.ToInt32 (Console.ReadLine());

if (userRows == userColumns) 
    Console.WriteLine ("Rows' number haven't be equal columns' number. Try again!");
else
{
    int [,] userMatrix = RectangularMatrix (userRows, userColumns);
    ShowMatrix (userMatrix);
    FindSmallestRow (userMatrix);
}*/

// Напишите программу, которая заполнит спирально массив 4 на 4.

/*int [,] SpiralMatrix ()
{
    int [,] matrix = new int [4,4];
    int num = 1;

    for (int j = 0; j < matrix.GetLength (1); j++)
        matrix [0, j] = num++;
    for (int i = 1; i < matrix.GetLength (0); i++)
        matrix [i, matrix.GetLength (1) - 1] = num++;
    for (int j = matrix.GetLength(1) - 2; j >=0; j--)
        matrix [matrix.GetLength (0) - 1, j] = num++;
    for (int i = matrix.GetLength(0) - 2; i > 0; i--)
        matrix [i, 0] = num++;
    for (int j = 1; j < matrix.GetLength (1) - 1; j++)
        matrix [1, j] = num++;
    for (int j = matrix.GetLength(1)-2; j < matrix.GetLength(1)-1; j++)
        matrix [2, j] = num++;
    matrix [matrix.GetLength(0) - 2, matrix.GetLength(1) -3] = num++;

    return matrix;
}

void ShowMatrix (int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < 10) Console.Write (matrix [i, j] + "  ");
            else Console.Write (matrix [i, j] + " ");
        }
        Console.WriteLine ();
    }
}

int [,] newMatrix = SpiralMatrix ();
ShowMatrix (newMatrix);*/