/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
*/

Console.WriteLine("Введите количество строк");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов");
int n = int.Parse(Console.ReadLine()!);
Random rnd = new Random();
int[,] array = GetArray(m, n);
Printarray(array);
SortArray(array);
Console.WriteLine( );
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
