//Task 19.
//Напишите программу, которая принимает на вход пятизначное 
//число и проверяет, является ли оно палиндромом.

/* bool CheckPolindrom(int number)
{
    int cutNumber = number;
    int reverseNumber = 0;
    while (cutNumber > 0)
    {
        reverseNumber = (reverseNumber + cutNumber % 10);
        cutNumber = cutNumber / 10;
        if (cutNumber > 0) reverseNumber = reverseNumber * 10;
    }

    return number == reverseNumber;
}

Console.WriteLine("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (CheckPolindrom(number)) Console.WriteLine($"Tne number {number} is palindrom.");
else Console.WriteLine($"Tne number {number} is NOT palindrom."); */

//Task 21.
//Напишите программу, которая принимает на вход координаты двух 
//точек и находит расстояние между ними в 3D пространстве.

/* double FindDistance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double deltaX = x1 - x2;
    double deltaY = y1 - y2;
    double deltaZ = z1 - z2;

    return Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
}

Console.WriteLine("Input x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Distance = {Math.Round(FindDistance(x1, y1, z1, x2, y2, z2), 2)}."); */

//Task 23.
//Напишите программу, которая принимает на вход число 
//(N) и выдаёт таблицу кубов чисел от 1 до N.
/* 
void WriteQuad(int number)
{
    for (int i = 1; i <= number; i++)
    {
        double qub = Math.Pow(i, 3);
        Console.WriteLine($"{i} - {qub}");
    }

}

int number = 0;
do
{
    Console.WriteLine("Input positive number: ");
    number = Convert.ToInt32(Console.ReadLine());
} while (number <= 0);

WriteQuad(number);  */

//Task 23. Для любых чисел(если число положительное увеличиваем счетчик от одного, если отрицательное уменьшаем)
//Напишите программу, которая принимает на вход число 
//(N) и выдаёт таблицу кубов чисел от 1 до N.

/* void WriteQuad(int number)
{
    //Var 1
    // if (number > 0)
    // {
    //     for (int i = 1; i <= number; i++)
    //     {
    //         double qub = Math.Pow(i, 3);
    //         Console.WriteLine($"{i} - {qub}");
    //     }
    // }
    // else
    // {
    //     for (int i = 1; i >= number; i--)
    //     {
    //         double qub = Math.Pow(i, 3);
    //         Console.WriteLine($"{i} - {qub}");
    //     }
    // }
    //Var 2
    int count = 1;
    while (count != number)
    {
        double qub = Math.Pow(count, 3);
        Console.WriteLine($"{count} - {qub}");
        if (number > 0) count++;
        else count--;
    }
}

Console.WriteLine("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

WriteQuad(number); */
