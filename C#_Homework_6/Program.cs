// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

/*int PositiveNums (int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

void ShowArray (int [] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write ($"{array[i]}, ");
    }
    Console.WriteLine ("\b\b]");
}

Console.Write ("Input quantity of your numbers: ");
int size = Convert.ToInt32 (Console.ReadLine ());
int [] userNums = new int [size];

for (int i = 0; i < userNums.Length; i++)
{
    Console.Write ("Input integer number: ");
    int number = Convert.ToInt32 (Console.ReadLine ());
    userNums [i] = number;  
}

ShowArray (userNums);
Console.WriteLine ($"Your array has {PositiveNums (userNums)} numbers bigger than 0.");*/



//Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

/*void Crossing (double k1, double k2, double b1, double b2)
{
    if (k1 == k2 & b1 != b2) Console.WriteLine ("These lines are parallel.");
    else if (k1 == k2 & b1 == b2) Console.WriteLine ("These lines have infinite points of crossing");
    else 
    {
        double [] array = new double [2];
        array [0] = (b2 - b1) / (k1 - k2);
        array [1] = k1 * array [0] + b1;
        Console.Write ($"The point of crossing is ({array[0]}; {array[1]})");
    }
}


Console.Write ("For seaching point of two lines' crossing y = k1*x + b1 and y = k2*x + b2 input k1: ");
double k1 = Convert.ToInt32 (Console.ReadLine ());

Console.Write ("Now input k2: ");
double k2 = Convert.ToInt32 (Console.ReadLine ());

Console.Write ("Input b1: ");
double b1 = Convert.ToInt32 (Console.ReadLine ());

Console.Write ("And input b2: ");
double b2 = Convert.ToInt32 (Console.ReadLine ());

Crossing (k1, k2, b1, b2);*/




