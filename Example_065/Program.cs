//Задача 65: Спирально заполнить двумерный массив

void FillArray2D(int[,] array)
{
    int numberRectangle = 0, M = array.GetLength(0), N = array.GetLength(1), i = 0, j = 0, number = 1;

    while (number <= M * N)
    {
        array[i, j] = number;

        if (i == numberRectangle && j < N - numberRectangle - 1) j++;
        else if (j == N - numberRectangle - 1 && i < M - numberRectangle - 1) i++;
        else if (i == M - numberRectangle - 1 && j > numberRectangle) j--;
        else i--;

        if (i == numberRectangle + 1 && j == numberRectangle && numberRectangle != N - numberRectangle - 1)

        {
            numberRectangle++;
        }
        number++;

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

int[,] array = new int[3, 3];
FillArray2D(array);
PrintArray2D(array);