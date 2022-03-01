//Задача 59: В прямоугольной матрице найти строку с наименьшей суммой элементов.

Console.WriteLine();

int[,] array = new int[10, 10];

void FillMatrix(int[,] array, int minNumber = 0, int maxNumber = 9)
{
    Random rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(minNumber, maxNumber + 1);
        }
    }
}

void PrintMarix(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == array.GetLength(1) - 1) Console.Write($"{array[i, j]} ");
            else Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[] SumInRow(int[,] array)
{
    int[] result = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            result[i] += array[i, j];
        }
    }
    return result;
}

void MinSumInRowResult(int[] array)
{
    int min = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < array[min]) min = i;
    }
    Console.WriteLine($"В строке №{min} наименьшая сумма элементов прямоугольной матрицы");
}

FillMatrix(array);
PrintMarix(array);
MinSumInRowResult(SumInRow(array));
Console.WriteLine();