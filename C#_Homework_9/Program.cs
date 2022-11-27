// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.

/*void ShowNumbers (int n)
{
    Console.Write (n + " ");
    if (n > 1) ShowNumbers (n-1);
}

Console.Write ("Input number: ");
int newNum = Convert.ToInt32 (Console.ReadLine());
ShowNumbers (newNum);*/

// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

/*int SumBetweenNums (int n, int m)
{
    if (n > m) return n + SumBetweenNums (n - 1, m);
    if (n < m) return m + SumBetweenNums (n, m - 1);
    //if (Math.Max (n, m) != Math.Min (n,m)) return SumBetweenNums (Math.Max (n, m) - 1, Math.Min (n,m)) + Math.Max (n, m);
    else return 0;
}

Console.Write ("Input first number: ");
int num1 = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Input second number: ");
int num2 = Convert.ToInt32 (Console.ReadLine());
int sum = Math.Min (num1,num2) + SumBetweenNums (num1, num2);
Console.WriteLine (sum);*/

// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

/*int Akkerman (int n, int m)
{
  if (n == 0) return m + 1;
  else if ((n != 0) && (m == 0)) return Akkerman(n - 1, 1);
  else return Akkerman(n - 1, Akkerman(n, m - 1));
}

Console.Write ("Input first positive number: ");
int num1 = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Input second positive number: ");
int num2 = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine (Akkerman (num1, num2));*/
