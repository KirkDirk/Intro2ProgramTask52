// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateArray2DimRandom(int row, int column)
{
    int[,] array = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}
void PrintArray2Dim(int[,] someArray)
{
    for (int i = 0; i < someArray.GetLength(0); i++)
    {
        for (int j = 0; j < someArray.GetLength(1); j++)
        {
            Console.Write($"{someArray[i, j]}  ");
        }
        Console.WriteLine();
    }
}
double ArithmeticMean(int[,] array, int indexColumn)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum = sum + array[i, indexColumn];
    }
    return (double) sum / (array.GetLength(0));
}

Console.Clear();
int rowArray = new Random().Next(1, 10);
int columnArray = new Random().Next(1, 10);
int[,] someArray = CreateArray2DimRandom(rowArray, columnArray);

Console.WriteLine($"Массив {rowArray}x{columnArray}:");
PrintArray2Dim(someArray);

Console.Write($"Среднее арифметическое каждого столбца:");
for (int i = 0; i < columnArray; i++)
{
    Console.Write($" {Math.Round(ArithmeticMean(someArray, i), 1)} ");
}