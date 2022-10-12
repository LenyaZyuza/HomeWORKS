// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

/*

int TwoDigitNumber(int num)
{
    int result = num / 10 % 10;
    return result;
}
Console.WriteLine("Input tree-digit number: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int twoDigit = TwoDigitNumber(numberA);
Console.WriteLine($"Second digit of {numberA} is {twoDigit}");

*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

/*  

int ThirdDigit(int num)
{
    int result = 0;
    if (num >= 100 && num <= 999)
        result = num % 10;
    else 
    if (num >= 1000 && num <= 9999)
        result = num / 10 % 10;
    else
    if (num >=10000 && num <= 99999)
        result = num / 100 % 10;
    
    return result;
}
int num = new Random().Next(1, 100000);

if (num >= 1 && num <= 99)
    Console.WriteLine("No third digit");
else
{
    int request = ThirdDigit(num);
    Console.WriteLine($"Received number = {num}, the third digit in the given number = {request}");
}

*/

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

/*

bool DayOff(int day)
{
    bool result;

    if (day == 6 || day == 7)
        result = true;
    else
        result = false;
    return result;
}
Console.Write("Input a number of the day of the week: ");
int dayWeek = Convert.ToInt32(Console.ReadLine());
bool dayOff = DayOff(dayWeek);

if (dayOff)
    Console.WriteLine($"Yes, the {dayWeek} day of the week is a holiday!");
else
    Console.WriteLine($"No, the {dayWeek} day of the week is not a holiday!");

*/