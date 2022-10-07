// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

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