//Задача 61: Найти произведение двух матриц

int[,] arrayFirst = new int[4, 2];
int[,] arraySecond = new int[2, 4];


void FillArray2D(int[,] array, int minNumber = 0, int maxNumber = 9)
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

void PrintArray2D(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == array.GetLength(1) - 1) Console.Write($"{array[i, j]} ");
            else Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MultMatrix(int[,] matrixFirst, int[,] matrixSecond)
{
    int[,] result = new int[matrixFirst.GetLength(0), matrixSecond.GetLongLength(1)];

    for (int i = 0; i < matrixFirst.GetLength(0); i++)
    {
        for (int j = 0; j < matrixSecond.GetLength(1); j++)
        {
            result[i, j] = 0;
            for (int k = 0; k < matrixFirst.GetLength(1); k++)
            {
                result[i, j] += matrixFirst[i, k] * matrixSecond[k, j];
            }
        }
    }

    return result;
}

FillArray2D(arrayFirst);
PrintArray2D(arrayFirst);
FillArray2D(arraySecond);
PrintArray2D(arraySecond);

PrintArray2D(MultMatrix(arrayFirst, arraySecond));