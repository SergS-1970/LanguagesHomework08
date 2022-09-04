/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

Console.Write("Введите размер квадратной матрицы (длина строки=высоте столбца): ");
int sideLength = Convert.ToInt32(Console.ReadLine());
int[,] squareArray = new int[sideLength, sideLength];

int i = 0;
int j = 0;

for (int elementValue = 1; elementValue <= (sideLength * sideLength); elementValue++)
{
    squareArray[i, j] = elementValue;

    if (i <= (j + 1) && (i + j) < sideLength - 1)
    j++;
    else if (i < j && (i + j) >= sideLength - 1)
    i++;
    else if (i >= j && (i + j) > sideLength -1)
    j--;
    else
    i--;
}

Console.WriteLine("Спирально заполненный квадратный массив: ");
for (int k = 0; k < sideLength; k++)
{
    for (int l = 0; l < sideLength; l++)
    {
        Console.Write(squareArray[k, l] + "\t");
    }
    Console.WriteLine();
}

