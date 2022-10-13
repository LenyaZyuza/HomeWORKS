// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

/*

void PalindromNumber(int num)
{
    if (num < 10000 || num > 99999)
    {
        Console.WriteLine("Non-five digit number entered!");
    }
    else
    {
        int firstDigit = num / 10000;
        int lastDigit = num % 10;

        if (firstDigit == lastDigit)
        {
            int newNum = num % 10000 / 10;
            firstDigit = newNum / 100;
            lastDigit = newNum % 10;

            if (firstDigit == lastDigit)
                Console.WriteLine($"The number {num} is a palindrome");
            else
                Console.WriteLine($"The number {num} is not a palindrome");
        }
        else
            Console.WriteLine($"The number {num} is not a palindrome");
    }
}
Console.Write("Enter a five-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
PalindromNumber(number);

*/

// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве

/*

double FindDistance(double xa, double ya, double za, double xb, double yb, double zb)
{
    double sumAB = Math.Pow((xb - xa),2) + Math.Pow((yb - ya),2) + Math.Pow((zb - za),2);
    double distance = Math.Round(Math.Sqrt(sumAB),2);
    return distance;
}
Console.Write("Input x-coordinate of point A: ");
double xa = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y-coordinate of point A: ");
double ya = Convert.ToDouble(Console.ReadLine());
Console.Write("Input z-coordinate of point A: ");
double za = Convert.ToDouble(Console.ReadLine());
Console.Write("Input x-coordinate of point B: ");
double xb = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y-coordinate of point A: ");
double yb = Convert.ToDouble(Console.ReadLine());
Console.Write("Input z-coordinate of point A: ");
double zb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"The distance between A({xa}, {ya}, {za}) and B({xb}, {yb}, {zb}) is: {FindDistance(xa, ya, za, xb, yb, zb)}");

*/

// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

/*

void FindCubeNumber(int num)
{
    int count = 1;
    while(count <= num)
    {
        Console.WriteLine(Math.Pow(count, 3));
        count++;
    }
}
Console.WriteLine("Input a positive number: ");
int num = Convert.ToInt32(Console.ReadLine());
FindCubeNumber(num);
if(num <= 0) 
{
    Console.Write("Incorrect input");
}

*/