// Программа, которая принимает на вход пятизначное число и проверяет, является ли число палидромом.

/*void Palidrom (int number)
{
    int digit1 = number / 10000;
    int digit2 = number / 1000 % 10;
    int digit4 = number % 100 / 10;
    int digit5 = number % 10;
    if (digit1 == digit5 & digit2 == digit4) Console.WriteLine ($"Number {number} is a palidrom");
    else Console.WriteLine ($"Number {number} is not a palidrom");
}

Console.Write ("Input five-digit number: ");
int userNum = Convert.ToInt32 (Console.ReadLine());
if (userNum > 9999 & userNum < 100000)
{
    Palidrom (userNum);
}
else
{
    Console.WriteLine ($"Number {userNum} is not five-digit.");
}*/

// Программа, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/*double Distance (int Ax, int Ay, int Az, int Bx, int By, int Bz)
{
    double distance = Math.Sqrt (((Bx - Ax)*(Bx - Ax)) + ((By - Ay)*(By - Ay)) + ((Bz - Az)*(Bz - Az)));
    distance = Math.Round (distance, 2);
    return distance;
}

Console.Write ("Input value of first point along the axis X: ");
int Point1_X = Convert.ToInt32 (Console.ReadLine ());
Console.Write ("Input value of first point along the axis Y: ");
int Point1_Y= Convert.ToInt32 (Console.ReadLine ());
Console.Write ("Input value of first point along the axis Z: ");
int Point1_Z = Convert.ToInt32 (Console.ReadLine ());
Console.Write ("Input value of second point along the axis X: ");
int Point2_X = Convert.ToInt32 (Console.ReadLine ());
Console.Write ("Input value of second point along the axis Y: ");
int Point2_Y = Convert.ToInt32 (Console.ReadLine ());
Console.Write ("Input value of second point along the axis Z: ");
int Point2_Z = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ($"The distance between point ({Point1_X}, {Point1_Y}, {Point1_Z}) and point ({Point2_X}, {Point2_Y}, {Point2_Z}) is {Distance (Point1_X, Point1_Y, Point1_Z, Point2_X, Point2_Y, Point2_Z)}.");
*/


//Программа, которая принимает на вход число N и выдает таблицу кубов чисел от 1 до N.

void TableOfNumberCube (int number)
{
    for (int count = 1; count <= number; count++)
    {
        Console.Write ($"{count*count*count} ");
    }
}

Console.Write ("Input number: ");
int userNum = Convert.ToInt32 (Console.ReadLine());
TableOfNumberCube (userNum);
