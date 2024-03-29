﻿// Программа, которая заполняет спирально массив, размер которого 4 х 4

int[,] spiralArray = new int[4, 4];
int temp = 1;
int i = 0;
int j = 0;

while (temp <= spiralArray.GetLength(0) * spiralArray.GetLength(1))
{
    spiralArray[i, j] = temp;
    temp++;
    if (i <= j + 1 && i + j < spiralArray.GetLength(1) - 1) j++;
    else if (i < j && i + j >= spiralArray.GetLength(0) - 1) i++;
    else if (i >= j && i + j > spiralArray.GetLength(1) - 1) j--;
    else i--;
}

PrintArray(spiralArray);

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] / 10 <= 0) Console.Write($" {array[i, j]} ");
            else Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}