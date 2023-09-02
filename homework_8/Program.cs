//Task 54. 
// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

void Sort2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i,k] < array[i,k + 1])
                    {
                        int temp = array[i,k];
                        array[i,k] = array[i,k + 1];
                        array[i,k + 1] = temp;
                    }
            }

        }
    }
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);

Sort2dArray(myArray);
Show2dArray(myArray); */

//Task 56. 
// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

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

int FindRowWithMinSum(int[,] array)
{
    int minSum = 0;
    int minRow = 1;

    for (int j = 0; j < array.GetLength(1); j++)
        minSum = minSum + array[0, j];

    for (int i = 1; i < array.GetLength(0); i++)
    {
        int sumRow = 0;

        for (int j = 0; j < array.GetLength(1); j++)
            sumRow = sumRow + array[i, j];

        if (sumRow < minSum)
        {
            minSum = sumRow;
            minRow = i + 1;
        }
    }

    return minRow;
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);

int minRow = FindRowWithMinSum(myArray);
Console.WriteLine($"Minimul sum of elements in a row with number {minRow}."); */

//Task  58. 
// Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

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

int[,] Multiplication2dArray(int[,] array1, int[,] array2)
{
    int[,] multiArr = new int[array1.GetLength(0), array2.GetLength(1)];

    for (int i = 0; i < multiArr.GetLength(0); i++)
    {
        for (int j = 0; j < multiArr.GetLength(1); j++)
            for (int n = 0; n < array1.GetLength(1); n++)
            {
                multiArr[i, j] = multiArr[i, j] + (array1[i, n] * array2[n, j]);
            }

    }

    return multiArr;
}

int[,] myArray1 = CreateRandom2dArray();
Show2dArray(myArray1);
int[,] myArray2 = CreateRandom2dArray();
Show2dArray(myArray2);

if (myArray1.GetLength(1) == myArray2.GetLength(0))
{
    int[,] multiArr = Multiplication2dArray(myArray1, myArray2);
    Show2dArray(multiArr);
}
else
    Console.WriteLine($"These arrays cannot be multiplied, the number of columns in the first array({myArray1.GetLength(1)}) is not equal to the number of rows in the second array({myArray2.GetLength(0)})."); */

// int minRow = FindRowWithMinSum(myArray);
// Console.WriteLine($"Minimul sum of elements in a row with number {minRow}.");

//Task 60. 
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.

/* int[,,] CreateRandom3dArray()
{
    int length = 2;
    int minValue = 10;
    int maxValue = 100;

    int[,,] array = new int[length, length, length];

    for (int i = 0; i < length; i++)
        for (int j = 0; j < length; j++)
            for (int k = 0; k < length; k++)
            {
                int number = 0;
                do
                {
                    number = new Random().Next(minValue, maxValue);
                } while (CheckNumber(number, array));

                array[i, j, k] = number;
            }

    return array;
}

void Show3dArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");

            Console.WriteLine();
        }
    }
    Console.WriteLine();
}

bool CheckNumber(int num, int[,,] arr)
{
    bool result = false;

    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
            for (int k = 0; k < arr.GetLength(2); k++)
                if (num == arr[i, j, k])
                    result = true;

    return result;

}

int[,,] myArray = CreateRandom3dArray();
Show3dArray(myArray); */

//Task 62. 
// Напишите программу, которая 
// заполнит спирально массив 4 на 4.
// ++ Заполняет любую прямоугольную матрицу даже если i != j.

/* int[,] CreateRandom2dArray()
{
    Console.WriteLine("Input quantity of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input quantity of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];


    int minI = 0;
    int minJ = 0;
    int maxI = rows - 1;
    int maxJ = columns - 1;
    int num = 1;
    int maxValue = rows * columns;

    while (num <= maxValue)
    {
        if (maxJ - minJ > 0)
        {
            for (int j = minJ; j <= maxJ; j++)
            {
                array[minI, j] = num;
                num = num + 1;
            }
            minI = minI + 1;
        }
        
        if (maxI - minI > 0)
        {
            for (int i = minI; i <= maxI; i++)
            {
                array[i, maxJ] = num;
                num = num + 1;
            }
            maxJ = maxJ - 1;
        }

        if (maxJ - minJ > 0)
        {
            for (int j = maxJ; j >= minJ; j--)
            {
                array[maxI, j] = num;
                num = num + 1;
            }
            maxI = maxI - 1;
        }

        if (maxI - minI > 0)
        {
            for (int i = maxI; i >= minI; i--)
            {
                array[i, minJ] = num;
                num = num + 1;
            }
            minJ = minJ + 1;
        }
    }

    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j].ToString("D3")  + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray); */