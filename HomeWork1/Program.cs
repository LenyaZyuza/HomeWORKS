// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*

Console.WriteLine("Input a fisrt number: ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input a second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());

if (n1 > n2)
{
    Console.WriteLine($"First number {n1} is greater then second number {n2}");
}
else if (n1 < n2)
{
    Console.WriteLine($"Second number {n2} is greater then fist number {n1}");
}
else
{
    Console.WriteLine($"First number {n1} and second number {n2} are equal.");
}

*/

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*

Console.WriteLine("Input a first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input a second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input a third number: ");
int n3 = Convert.ToInt32(Console.ReadLine());

int greater = n1;

if(n2 > greater)
{
    greater = n2;
}
if(n3 > greater)
{
    greater = n3;
}
Console.WriteLine($"Greater number is {greater}");

*/

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*

Console.WriteLine("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n % 2 == 0)
{
    Console.WriteLine($"Number {n} is even");
}
else
{
    Console.WriteLine($"Number {n} is odd uneven");
}

*/

// Задача 8:Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

/*

Console.WriteLine("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n > 0)
{
    int current = 2;
    while (current <= n)
    {
        Console.Write(current + " ");
        current += 2;    
    }
}

*/