// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

/*int[] CreateRandomArray(int size, int minValue, int maxValue)
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
int CounterOfEvenNumbers(int[] array)
{   
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        count ++;
    }
    return count;
}
Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
int min = 100;
int max = 999;
int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);
int countOfEvenNumbers = CounterOfEvenNumbers(myArray);
Console.WriteLine($"The number of even numbers in your array is: {countOfEvenNumbers}");*/

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

/*int[] CreateRandomArray(int size, int minValue, int maxValue)
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
int SumOfDifElements(int[] array)
{   
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(i % 2 != 0)
        sum += array[i];
    }
    return sum;
}
Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
int min = -10;
int max = 10;
int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);
int sumOfDifElements = SumOfDifElements(myArray);
Console.WriteLine($"The sum of the odd elements in your array is: {sumOfDifElements}");*/

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

/*double[] CreateArray(int size)
{
    double[] array = new double[size];
    Console.WriteLine("Creating array: ");
    for(int i = 0; i < size; i++)
    {
        Console.Write($"Input a {i + 1} element of array: ");
        array[i] = Convert.ToDouble(Console.ReadLine());
    }
    Console.WriteLine("Complete!");
    return array;
}
void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    
        Console.Write(array[i] + " ");   
    Console.WriteLine();
}
double DifferenceBetweenMinAndMax(double[] array)
{   
    double diff = 0;
    double max = array[0];
    double min = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < min)
            min = array[i];
        if(array[i] > max)
            max = array[i];
    }
    diff = max - min;
    return diff;
}
Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] myArray = CreateArray(size);
ShowArray(myArray);
double differenceBetweenMinAndMax = DifferenceBetweenMinAndMax(myArray);
Console.WriteLine($"The difference between the max and min array elements is: {differenceBetweenMinAndMax}");*/