//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns);
PrintArray(array);
Console.WriteLine();
Console.Write("Среднее арифметическое каждого столбца : ");
AverageSumEveryColumns(array);

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(0, 10);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void AverageSumEveryColumns(int[,] inArray)
{
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
        double sumofelements = 0;
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            sumofelements += inArray[i, j];
        }
        double averagesumofelements = Math.Round(sumofelements / inArray.GetLength(0), 2);
        Console.Write($"{averagesumofelements} ; ");
    }
}

