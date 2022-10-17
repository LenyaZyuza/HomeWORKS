// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

/*

int GetExponentiation (int a, int b)
{
    int product = 1;
    for(int current = 1; current <= b; current++)
    {
        product *= a;
    }
    return product;
}
Console.Write("Input a number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input degree of number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int exponentiation = GetExponentiation(num1, num2);
Console.WriteLine($"The number {num1} to the power {num2} is {exponentiation}");

*/

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/*

Console.Clear();
int SumDigits(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum = sum + num % 10;
        num /= 10;
    }
    return sum;
}
Console.Write("Input a nubmer: ");
int num = Convert.ToInt32(Console.ReadLine());
int sumDigits = SumDigits(num);
Console.WriteLine($"The sum of the digits in a number {num} = {sumDigits}");
Console.ReadLine();
*/

// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

/*

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue +1);
    return newArray;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    
        Console.Write(array[i] + " ");   
    Console.WriteLine();
}
Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
int min = 0;
int max = 99;
int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);

*/