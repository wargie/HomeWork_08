// Задача 57: Написать программу, которая упорядочивает по убыванию элементы каждой строки двумерной массива.

int row = 4, col = 7;
Random random = new Random();

int[,] GetMatrix(int row, int col)
    {
        int[,] arr = new int[row, col];

            for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                        {
                            arr[i, j] =  random.Next(1, 100);
                        }
                }
            return arr;
    }

int[,] SortRowAscending(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                    {
                        int minPosition = j;                                            
                        for (int k = j + 1; k < array.GetLength(1); k++)                
                            {
                                if (array[i, k] > array[i, minPosition]) minPosition = k;    
                            }
                        int tmp = array[i, j];                                          
                        array[i, j] = array[i, minPosition];                            
                        array[i, minPosition] = tmp;                                    
                    }

            }
        return array;
    }

void PrintTable(int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        Console.Write(arr[i, j] + "  ");
                    }
                Console.WriteLine();
            }
    }



int[,] table = GetMatrix(row, col);
PrintTable(table);

Console.WriteLine();
int[,] rowSort = SortRowAscending(table);
PrintTable(rowSort);