// Напишите программу, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B (Math.Pow НЕ использовать)

/*int ElevateToPower (int num, int power)
{
    int result = 1;
    for (int i = 0; i < power; i++)
    {
        result *= num;
    }
    return result;
}

Console.Write ("Input number: ");
int userNum = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Input power which you want elevate your number: ");
int userPower = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ($"{userNum} to the power {userPower} is {ElevateToPower (userNum, userPower)}");*/

// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/*int SumOfDigits (int num)
{
    int sum = 0;
    while (num > 0)
    {
        int rest = num%10;
        sum += rest;
        num = num/10;
    }
    return sum;
}

Console.Write ("Input positive integer number: ");
int userNum = Convert.ToInt32 (Console.ReadLine());
while (userNum <= 0)
{
    Console.Write ("Please, input positive integer number: ");
    userNum = Convert.ToInt32 (Console.ReadLine()); 
} 
Console.WriteLine ($"The sum of digits in number {userNum} is {SumOfDigits(userNum)}");*/

// Напишите программу, которая создает массив заданного пользователем размера, 
// заполняет массив элементами от 1 до 99 и выводит их на экран.

/*int [] FillArray (int lengthArr)
{
    int [] array = new int [lengthArr];
    for (int i = 0; i < lengthArr; i++)
    {
        array [i] = new Random().Next (1, 100);
    }
    return array;
}

void PrintArray (int [] array)
{
    Console.Write ("[");
    for (int i = 0; i < array.Length; i++)
        Console.Write ($"{array[i]}, ");
    Console.Write ("\b\b]");
}

Console.Write ("Input the length of your array: ");
int userLength = Convert.ToInt32 (Console.ReadLine());
PrintArray (FillArray(userLength));*/