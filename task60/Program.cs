/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 

которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

Console.Write("Введите ширину трёхмерного  массива: ");
int width = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите высоту трёхмерного массива: ");
int height = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите глубину трёхмерного массива: ");
int depth = Convert.ToInt32(Console.ReadLine());

int[,,] array = new int[width, height, depth];

int[] tempArray = new int[width * height * depth];
if (width * height * depth > 90)
{
    Console.WriteLine("Массив данного размера невозможно сформировать из неповторяющихся двузначных чисел");
}

else
{
    for (int i = 0; i < width * height * depth; i++)
    {
        tempArray[i] = new Random().Next(10, 100);
        int removingDuplicates = tempArray[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (tempArray[i] == tempArray[j])
                {
                    tempArray[i] = new Random().Next(10, 100);
                    j = 0;
                    removingDuplicates = tempArray[i];
                }
                removingDuplicates = tempArray[i];
            }
        }
    }

    int auxiliaryIndex = 0;

    for (int i = 0; i < width; i++)
    {
        for (int j = 0; j < height; j++)
        {
            for (int k = 0; k < depth; k++)
            {
                array[i, j, k] = tempArray[auxiliaryIndex];
                auxiliaryIndex++;

            }
        }
    }

    Console.WriteLine(" \t\t Трёхмерный массив ");

    for (int i = 0; i < width; i++)
    {
        for (int j = 0; j < height; j++)
        {
            for (int k = 0; k < depth; k++)
            {

                Console.Write($"\t{array[i, j, k]} [{i},{j},{k}]\t");
            }
            Console.WriteLine();
        }
    }
}