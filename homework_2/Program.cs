// Task 10.  Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает вторую цифру этого числа.

/*
int CutNumber(int num)
{
    num = num / 10;
    num = num % 10;

    return num ;  
}

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int secondDidgit = CutNumber(number);

Console.WriteLine($"The second digit of {number} is {secondDidgit}");
*/

// Task 13. Напишите программу, которая выводит третью цифру
// заданного числа ( или -1, если третьей цифры нет).

/*
int FindTherdDigit(int num)
{
    if (num > 99)
    {
        num = num % 1000;
        num = num / 100;
        return num;
    }
    else return -1;
}

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int res = FindTherdDigit(number);

if (res == -1) Console.Write("The number contains less than three digits, the error code is (-1).");
else Console.Write($"the third digit in the number {number} is {res}");
*/


// Task 15. Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

/*
bool FindWeekend(int num)
{
    return (num == 6 || num == 7);
}
bool FromOneToSeven(int num)
{
    return (num > 0 && num < 8);
}

Console.Write("Input a day number: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

if (FromOneToSeven(dayNumber))
{
    if (FindWeekend(dayNumber)) Console.Write($"{dayNumber} this is a weekend");
    else Console.Write($"{dayNumber} this is a working day");
}
else Console.Write($"The entered number ({dayNumber}) is not the number of the day of the week");
*/
