// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

/*int [] FillUpArr (int size)
{
    int [] array = new int [size];
    for (int i =0; i < array.Length; i++)
    {
        array [i] = new Random().Next (100, 1000);
    }
    return array;
}

void PrintArr (int [] array)
{
    Console.Write ("[");
    for (int i =0; i < array.Length; i++) 
    {
        Console.Write ($"{array[i]}, ");
    }
    Console.WriteLine ("\b\b]");
}

int EvenNums (int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i]%2 == 0) count++;
    }
    return count;
}

Console.Write ("Input number of array's elements: ");
int currentSize = Convert.ToInt32 (Console.ReadLine());
int [] currentArray = FillUpArr(currentSize);
PrintArr(currentArray);
Console.WriteLine ($"There are {EvenNums(currentArray)} even numbers in array.");*/

//Задайте массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

/*int [] FillUpArr (int size, int minNum, int maxNum)
{
    int [] array = new int [size];
    for (int i =0; i < array.Length; i++)
    {
        array [i] = new Random().Next (minNum, maxNum + 1);
    }
    return array;
}

void PrintArr (int [] array)
{
    Console.Write ("[");
    for (int i =0; i < array.Length; i++) 
    {
        Console.Write ($"{array[i]}, ");
    }
    Console.WriteLine ("\b\b]");
}

int EvenNums (int [] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        sum += array [i];
    }
    return sum;
}

Console.Write ("Input number of array's elements: ");
int currentSize = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Input min value of array: ");
int currentMin = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Input max value of array: ");
int currentMax = Convert.ToInt32 (Console.ReadLine());

int [] currentArray = FillUpArr(currentSize, currentMin, currentMax);
PrintArr(currentArray);
Console.WriteLine ($"The sum of odd elements of array is {EvenNums(currentArray)}.");*/

// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

/*double [] FillUpArr (int size)
{
    double [] array = new double [size];
    for (int i =0; i < array.Length; i++)
    {
        array [i] = new Random().Next (0, 101);
        array [i] += Math.Round (new Random().NextDouble (), 1);
    }
    return array;
}

void PrintArr (double [] array)
{
    Console.Write ("[");
    for (int i =0; i < array.Length; i++) 
    {
        Console.Write ($"{array[i]}; ");
    }
    Console.WriteLine ("\b\b]");
}

double DifferenceMinMax (double [] array)
{
    double max = array [0];
    double min = array [1];
    if (array [0] < array [1]) 
    {
        max = array [1];
        min = array [0];
    }
    for (int i = 2; i < array.Length; i++)
    {
        if (array [i] > max) max = array[i];
        else if (array [i] < min) min = array[i];
    }
    double difference = Math.Round (max - min, 1);
    return difference;
}

double [] currArray = FillUpArr (10);
PrintArr (currArray);
Console.WriteLine ($"Difference between min number and max number is {DifferenceMinMax (currArray)}");*/