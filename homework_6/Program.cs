// Task 41.
// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

/* int[] InputArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Input {i + 1} value: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }

    return array;
}

void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}


int CountGreatZero(int[] array)
{

    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            count++;
    }

    return count;
}

Console.WriteLine("Input length of an array (M): ");
int m = Convert.ToInt32(Console.ReadLine());

int[] myArray = InputArray(m);
WriteArray(myArray);
int greatZero = CountGreatZero(myArray);

Console.WriteLine($"The number of elements is greater than zero: {greatZero}"); */

// Task 41.1

/* int InputNumbersAndCount(int size)
{

    int count = 0;
    int number = 0;

    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Input {i + 1} value: ");
        number = Convert.ToInt32(Console.ReadLine());
        if (number > 0)
            count++;
    }

    return count;
}


Console.WriteLine("Input length of an array (M): ");
int m = Convert.ToInt32(Console.ReadLine());

int greatZero = InputNumbersAndCount(m);

Console.WriteLine($"The number of elements is greater than zero: {greatZero}");
 */

// Task 43. 
// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

/* double[] InputValueOfConstant()
{
    double[] constantArr = new double[4];

    Console.WriteLine("Input k1 value: ");
    constantArr[0] = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Input b1 value: ");
    constantArr[1] = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Input k2 value: ");
    constantArr[2] = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Input b2 value: ");
    constantArr[3] = Convert.ToDouble(Console.ReadLine());

    return constantArr;

}

void FindIntersectionPoint(double[] constantArr)
{
    double k1 = constantArr[0];
    double b1 = constantArr[1];
    double k2 = constantArr[2];
    double b2 = constantArr[3];

    double x = 0;
    double y = 0;
    if (k1 == k2)
        Console.WriteLine("straight lines are parallel.");
    else
    {
        x = (b2 - b1) / (k1 - k2);
        y = k1 * x + b1;
    }

    Console.WriteLine($"The intersection point is ({x}, {y})");

}

double[] constantArr = InputValueOfConstant();
FindIntersectionPoint(constantArr); */

//Extra Task
// Написать программу, преобразующую число 
// из десятеричной системы счисления в двоичную.
/* 
int[] DecToBin(int number10)
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