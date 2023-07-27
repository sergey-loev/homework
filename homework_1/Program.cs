//////////////
//Homework_1//
//////////////

// Task 2    
// Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.

/*
Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2) Console.Write("Max number is " + num1);
else Console.Write("Max number is " + num2);
*/

// Task 4
// Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.

/*
Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int maxNum = num1;

if (num2 > maxNum) maxNum = num2;
if (num3 > maxNum) maxNum = num3;

Console.Write("Max number is " + maxNum);
*/

// Task 6
// Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).

/*
Console.Write("Input a  number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0) Console.Write("Number is even");
else Console.Write("Number is odd");
*/

// Task 8
// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

/*
Console.Write("Input a  number: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = 2;

while (current < num)
{
    Console.Write(current + " ");
    current = current + 2;
}
*/

