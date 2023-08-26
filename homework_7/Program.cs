// Task 47. 
// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

/* double[,] CreateRandom2dArray()
{
    Console.WriteLine("Input quantity of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input quantity of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input min possible value: ");
    double minValue = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Input max possible value: ");
    double maxValue = Convert.ToDouble(Console.ReadLine());

    double[,] array = new double[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().NextDouble() * (maxValue - minValue) + minValue;

    return array;
}

void Show2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
}

double[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
 */

// Task 50. 
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

/* int[,] CreateRandom2dArray()
{
    Console.WriteLine("Input quantity of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input quantity of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }

    Console.WriteLine();
}

void FindAndShowElement(int i, int j, int[,] array)
{
    if (i + 1 > array.GetLength(0) || j + 1 > array.GetLength(1))
        Console.WriteLine("There is no such element!");
    else
        Console.WriteLine($"The value of element: {array[i, j]}");
}



int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);

Console.WriteLine("Input [i] position value: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input [j] position value: ");
int j = Convert.ToInt32(Console.ReadLine());

FindAndShowElement(i, j, myArray); */

// Task 52. 
// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

/* int[,] CreateRandom2dArray()
{
    Console.WriteLine("Input quantity of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input quantity of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }

    Console.WriteLine();
}

void ShowArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

double[] AverageRows(int[,] array)
{

    double[] arrRows = new double[array.GetLength(1)];

    for (int j = 0; j < array.GetLength(0); j++)
    {
        double sumOfRow = 0;

        for (int i = 0; i < array.GetLength(1); i++)
            sumOfRow = sumOfRow + array[i, j];

        arrRows[j] = sumOfRow / Convert.ToDouble(array.GetLength(0));
    }

    return arrRows;
}



int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
double[] averageRowsArr = AverageRows(myArray);
ShowArray(averageRowsArr); */

//Extra Task
// Написать программу, преобразующую число 
// из десятеричной системы счисления в двоичную.

/* int[] DecToBin(int number10)
{
    int div = 0;
    int count = 20;
    int[] arr2 = new int[count];

    while (number10 > 0)
    {
        div = number10 % 2;
        arr2[count - 1] = div;
        number10 = number10 / 2;
        count--;
    }

    return arr2;
}

void WriteBin(int[] array)
{
    int count = 0;
    while (array[count] == 0)
        count++;

    for (int i = count; i < array.Length; i++)
        Console.Write(array[i]);

    Console.WriteLine();
}

Console.WriteLine($"Input number value: ");
int num10 = Convert.ToInt32(Console.ReadLine());
int[] binArray = DecToBin(num10);
WriteBin(binArray);
 */