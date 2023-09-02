// Task 64.
// Задайте значение N. Напишите программу, которая 
// выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

/* void PrintNumber(int num)
{
    if (num == 1)
    {
        Console.Write(num + " ");
    }
    else
    {
        Console.Write(num + " ");
        PrintNumber(num - 1);
    }
}

Console.WriteLine("Input the number: ");
int number = Convert.ToInt32(Console.ReadLine());
PrintNumber(number); */

// Task 66.
// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

/* int SumNumbers(int m, int n)
{
    if (n == m)
    {
        return n;
    }
    else
    {
        return n + SumNumbers(m, n - 1);
    }
}

Console.WriteLine("Input the M number: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the N number: ");
int numberN = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"The sum of the numbers in the range from ({numberM},{numberN}) = {SumNumbers(numberM, numberN)}"); */

// Task 68.
// Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

/* int AckermannFunction(int M, int N)
{
    if (M == 0)
        return N + 1;
    if (M != 0 && N == 0)
        return AckermannFunction(M - 1, 1);
    else
        return AckermannFunction(M - 1, AckermannFunction(M, N - 1));
}

Console.WriteLine("Input the M number: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the N number: ");
int numberN = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Value Ackermann function A({numberM},{numberN}) = {AckermannFunction(numberM, numberN)}"); */