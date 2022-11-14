/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
*/
/*
Console.WriteLine("Введите количество строк");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов");
int n = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(m, n);
Printarray(array);
SortArray(array);
Console.WriteLine();
Printarray(array);

int[,] GetArray(int m, int n)
{

    int[,] arr = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int L = 0; L < n; L++)
        {
            arr[i, L] = new Random().Next(1, 10);
        }
    }
    return arr;
}

void Printarray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine("]");
    }
}

void SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int h = 0; h < array.GetLength(1) - 1; h++)
            {

                if (array[i, h] < array[i, h + 1])
                {
                    int x = array[i, h + 1];
                    array[i, h + 1] = array[i, h];
                    array[i, h] = x;
                }
            }
        }
    }
}
*/

/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
*/
/*
Console.WriteLine("Введите количество строк");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов");
int n = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(m, n);
Printarray(array);
MinSum(array);

int[,] GetArray(int m, int n)
{

    int[,] arr = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int L = 0; L < n; L++)
        {
            arr[i, L] = new Random().Next(1, 10);
        }
    }
    return arr;
}

void Printarray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine("]");
    }
}

void MinSum(int[,] array)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minRow += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) sumRow += array[i, j];
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    Console.WriteLine($"номер строки с наименьшей суммой элементов:{minSumRow + 1} строка");
}
*/

/*
Задача 58: Задайте две квадратные матрицы. Напишите программу, которая будет находить произведение двух матриц.
*/
/*
Console.WriteLine("Введите количество строк 1-го массива");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов 1-го массива");
int n = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(m, n);
Printarray(array);
Console.WriteLine("");
Console.WriteLine("Введите количество строк 2-го массива");
int x = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов 2-го массива");
int y = int.Parse(Console.ReadLine()!);
int[,] array2 = GetArray(x, y);
Printarray(array2);
int[,] ResultArray = new int[m, y];
Console.WriteLine("");
MultiplyArray(array, array2, ResultArray);
Console.WriteLine($"Произведение двух массивов");
Printarray(ResultArray);

int[,] GetArray(int m, int n)
{
    int[,] arr = new int[m, n];
    if (m == n)
    {
        for (int i = 0; i < m; i++)
        {
            for (int L = 0; L < n; L++)
            {
                arr[i, L] = new Random().Next(1, 10);
            }
        }
        return arr;
    }
    else
    {
        Console.WriteLine("Матрица не квадратная");
        return arr;
    }

}

void Printarray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine("]");
    }
}

void MultiplyArray(int[,] array, int[,] aray2, int[,] ResultArray)
{
    if (array.GetLength(0) == array2.GetLength(0))
    {
        if (array.GetLength(1) == array2.GetLength(1))
        {
            for (int i = 0; i < ResultArray.GetLength(0); i++)
            {
                for (int j = 0; j < ResultArray.GetLength(1); j++)
                {
                    int sum = 0;
                    for (int h = 0; h < array.GetLength(1); h++)
                    {
                        sum += array[i, h] * array2[h, j];
                    }
                    ResultArray[i, j] = sum;
                }
            }
        }
    }
}
*/

/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
*/
/*
int arraySizeX = 2;
int arraySizeY = 2;
int arraySizeZ = 2;
int minNumber = 1;
int maxNumber = 99;
int[,,] Array = new int[arraySizeX, arraySizeY, arraySizeZ];
FillArrayRandomNumber(Array, minNumber, maxNumber);
PrintArray(Array);
void FillArrayRandomNumber(int[,,] array, int minNumber = 0, int maxNumber = 9)
{
    Random rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int h = 0; h < array.GetLength(2); h++)
            {
                while (array[i, j, h] == 0)
                {
                    int number = rnd.Next(minNumber, maxNumber + 1);

                    if (IsNumberInArray(array, number) == false)
                    {
                        array[i, j, h] = number;
                    }
                }

            }
        }
    }
}

bool IsNumberInArray(int[,,] array, int number)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int h = 0; h < array.GetLength(2); h++)
            {
                if (array[i, j, h] == number) return true;
            }
        }
    }

    return false;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int h = 0; h < array.GetLength(2); h++)
            {
                Console.Write(array[i, j, h]);
                Console.Write("({0},{1},{2})\t", i, j, h);
            }

            Console.WriteLine();
        }

        Console.WriteLine();
    }
}
*/