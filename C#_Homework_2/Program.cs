// Задача 10. Программа, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа.

int FindSecondDigit (int number)
{
    int digit2 = 0;
    if (number > 99 && number <1000)
    {
        digit2 = (number / 10)%10;
    } 
    else 
    {
        digit2 = -1;
    }
    return digit2;
}

Console.WriteLine ("Input three-digit number: ");
int userNum = Convert.ToInt32(Console.ReadLine());
int secondDigit = FindSecondDigit (userNum);
if (secondDigit > 0) 
{
    Console.WriteLine ($"The second digit of {userNum} is {secondDigit}");
}
else 
{
    Console.WriteLine ($"{userNum} is not three-digit number.");
}

//Задача 13. Программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

/*int FindThirdDigit (int number)
{
    int digit3 = 0;
    if (number < 100) digit3 = -1; 
    if (number < 1000 && number > 99) digit3 = number%10;
    if (number > 999) {
        while (number > 999){
            number = number / 10;
        }
        digit3 = number%10;
    }
    return digit3;
}

Console.WriteLine ("Input number: ");
int userNum = Convert.ToInt32(Console.ReadLine());
int thirdDigit = FindThirdDigit (userNum);
if (thirdDigit > 0)
{
    Console.WriteLine ($"The third digit of {userNum} is {thirdDigit}");
}
else 
{
    Console.WriteLine ($"The number {userNum} doesn't have the third digit");
}*/

//Задача 15. Программа, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

/*void FindWeekEnd (int number)
{
    if (number <= 7 && number >= 1){
        if (number == 6 || number == 7){
            Console.WriteLine ("This day is a day off.");
        }
        else {
            Console.WriteLine ("This day is a working day.");
        }
    } 
    else {
        Console.WriteLine ("The week have only 7 days. Try again.");
    }
}

Console.WriteLine ("Input number of the week day: ");
int userNum = Convert.ToInt32(Console.ReadLine());
FindWeekEnd (userNum);*/