// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

/*
void ShowNums(int n)
{
    Console.Write(n + " ");
    if (n > 1) ShowNums(n - 1);
}
int n = 6;
Console.Write($"N = {n} -> ");
ShowNums(n);
*/

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

/*
int SumElements(int firstNum, int lastNum)
{
    if (firstNum > lastNum) return firstNum + SumElements(firstNum - 1, lastNum);
    if (firstNum < lastNum) return firstNum + SumElements(firstNum + 1, lastNum);
    else return firstNum;
}

 Console.Write("Input a number m: ");
 int m = Convert.ToInt32(Console.ReadLine());

 Console.Write("Input a number n: ");
 int n = Convert.ToInt32(Console.ReadLine());

 int result = SumElements(m,n);
 Console.WriteLine("The sum of natural elemetns in the range from m to n: " + result);
*/

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int A(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return A(m - 1, 1);
    if (m > 0 && n > 0) return A(m - 1, A(m,n - 1));
    return A(m,n); 
}                  

 Console.Write("Input a number m greater than 0: ");
 int m = Convert.ToInt32(Console.ReadLine());

 Console.Write("Input a number m greater than 0: ");
 int n = Convert.ToInt32(Console.ReadLine());

 Console.WriteLine($"m = {m}, n = {n} -> A(m,n) = {A(m,n)}"); 


