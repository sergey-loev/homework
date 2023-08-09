// Task 25. 
//Напишите цикл, который принимает на вход два 
//числа (A и B) и возводит число A в натуральную степень B.

/* int Exponentiation(int number, int degree)
{
    int result = number;

    for (int i = 1; i < degree; i++) 
        result = result * number;

    return result;

}

Console.WriteLine("Input number:");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input degree:");
int deg = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Rezult of exponentiation = " + Exponentiation(num, deg));
Console.WriteLine("Rezult of Math.Pow = " + Math.Pow(num,deg)); */

//Task 27. 
//Напишите программу, которая принимает 
//на вход число и выдаёт сумму цифр в числе.

/* int SumOfDigits(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum = sum + number % 10;
        number = number / 10;
    }
    return sum;
}

Console.WriteLine("Input number:");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Sum of digits: " + SumOfDigits(number)); */


//Task 29. 
//Напишите программу, которая задаёт 
//массив из m элементов и выводит их на экран.

/* int[] FillInArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Input {i + 1} element of array: ");
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

Console.WriteLine("Input length of an array: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] myArray = FillInArray(length);
WriteArray(myArray); */











