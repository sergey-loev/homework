//Task 34.
//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

/* int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int QuantityOfEven(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0)
            count++;
        
    return count;
}

Console.WriteLine("Input length of an array: ");
int length = Convert.ToInt32(Console.ReadLine());
int min = 100;
int max = 999;

int[] myArray = CreateRandomArray(length, min, max);
WriteArray(myArray);
Console.WriteLine(QuantityOfEven(myArray)); */

//Task 36. 
//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

/* int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int SumOfOdd(int[] array)
{
    int sum = 0;

    for (int i = 1; i < array.Length; i = i + 2)
        sum += array[i];

    return sum;
}

Console.WriteLine("Input length of an array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);
WriteArray(myArray);
Console.WriteLine(SumOfOdd(myArray)); */

//Task 38. 
//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

/* double[] FillInArray(int size)
{
    double[] array = new double[size];

    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Input {i + 1} element of array: ");
        array[i] = Convert.ToDouble(Console.ReadLine());
    }

    return array;
}

void WriteArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

double DifferenceMaxMin(double[] array)
{
    double min = array[0];
    double max = array[0];

    double dif = 0;

    for (int i = 1; i < array.Length; i++)
    {
        if (min > array[i])
            min = array[i];
        else if (max < array[i])
            max = array[i];
    }

    dif = max - min;

    return dif;
}

Console.WriteLine("Input length of an array: ");
int length = Convert.ToInt32(Console.ReadLine());

double[] myArray = FillInArray(length);
WriteArray(myArray);

Console.WriteLine(Math.Round(DifferenceMaxMin(myArray), 2)); */
