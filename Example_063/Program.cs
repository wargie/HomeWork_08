//Задача 63: Сформировать трехмерный массив не повторяющимися двузначными числами. Показать его построчно, выводя на экран индексы соответствующего элемента.

int[,,] array = new int[4, 4, 4];

void FillArray3D(int[,,] array)
{
    int number = 10;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = number;
                number++;
            }
        }
    }
}

void PrintArray3D(int[,,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.WriteLine($"Элемент с индексом [{i}, {j}, {k}] - {array[i, j, k]} ");

            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

FillArray3D(array);
PrintArray3D(array);