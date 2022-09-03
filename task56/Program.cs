/* Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 
1 строка */

Console.Write("Введите количество строк m: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов n: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, columns];
int[] sumElementsOfRow = new int[rows];

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        array[i, j] = new Random().Next(11);
        sumElementsOfRow[i] += array[i, j];
    }
}

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}

Console.WriteLine("Сумма элементов строки: ");
Console.WriteLine($"[{String.Join("\t", sumElementsOfRow)}]");

int rowIndexWithMinSum = 0;
for (int k = 1; k < rows; k++)
{
    if (sumElementsOfRow[k] < sumElementsOfRow[k - 1]) rowIndexWithMinSum = k;
}

Console.WriteLine($"Номер строки с минимальной суммой элементов: {rowIndexWithMinSum + 1}");
