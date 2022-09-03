/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

Console.Write("Введите для  массива A количество строк: ");
int rowsA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите для  массива A количество столбцов: ");
int columnsA = Convert.ToInt32(Console.ReadLine());

int[,] arrayA = new int[rowsA, columnsA];

for (int i = 0; i < rowsA; i++)
{
    for (int j = 0; j < columnsA; j++)
    {
        //arrayA[i, j] = Convert.ToInt32(Console.ReadLine()); (использовал для тестирования)
        arrayA[i, j] = new Random().Next(11);
    }
}

Console.WriteLine(" Матрица A ");

for (int i = 0; i < rowsA; i++)
{
    for (int j = 0; j < columnsA; j++)
    {
        Console.Write(arrayA[i, j] + "\t");
    }
    Console.WriteLine();
}

Console.Write("Введите для  массива B количество строк: ");
int rowsB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите для  массива B количество столбцов: ");
int columnsB = Convert.ToInt32(Console.ReadLine());

int[,] arrayB = new int[rowsB, columnsB];

for (int k = 0; k < rowsB; k++)
{
    for (int l = 0; l < columnsB; l++)
    {
        arrayB[k, l] = new Random().Next(11);
        //arrayB[k, l] = Convert.ToInt32(Console.ReadLine());(использовал для тестирования)
    }
}

Console.WriteLine(" Матрица B ");

for (int k = 0; k < rowsB; k++)
{
    for (int l = 0; l < columnsB; l++)
    {
        Console.Write(arrayB[k, l] + "\t");
    }
    Console.WriteLine();
}

int[,] matrixProductAB = new int[rowsA, columnsB];

if (columnsA != rowsB) Console.WriteLine(" Матрицы не согласованы. Операция умножения невозможна.");

else
{

    for (int m = 0; m < rowsA; m++)
    {
        for (int n = 0; n < columnsB; n++)
        {
            for (int i = m; i < rowsA; i++)
            {
                for (int j = 0; j < columnsA; j++)
                {
                    for (int k = 0; k < rowsB; k++)
                    {
                        for (int l = n; l < columnsB; l++)
                        {
                            if (i == m && l == n && j == k)
                                matrixProductAB[m, n] += arrayA[i, j] * arrayB[k, l];
                        }

                    }
                }
            }
        }
    }
}


Console.WriteLine("Произведение матриц AB");

for (int m = 0; m < rowsA; m++)
{
    for (int n = 0; n < columnsB; n++)
    {
        Console.Write(matrixProductAB[m, n] + "\t");
    }
    Console.WriteLine();
}