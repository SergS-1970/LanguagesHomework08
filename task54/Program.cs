/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

Console.Write("Введите количество строк m: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов n: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, columns];

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        array[i, j] = new Random().Next(100);
    }
}

Console.WriteLine("Исходный массив: ");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}

for (int accountingForSorted = 0; accountingForSorted < columns; accountingForSorted++)
{
    for (int i = 0; i < rows; i++)
    {
        int maxElementOfString = array[i, accountingForSorted];
        for (int j = accountingForSorted; j < columns; j++)
        {

            if (array[i, j] > maxElementOfString)
            {
                maxElementOfString = array[i, j];
                int auxiliaryValue = array[i, accountingForSorted];
                array[i, accountingForSorted] = maxElementOfString;
                array[i, j] = auxiliaryValue;
            }



        }
    }


}

Console.WriteLine("Итоговый массив: ");

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}
