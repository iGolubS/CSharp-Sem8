// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю 
// строку массива.

Console.Clear();

void fillMatrixWithRandomIntegers(int[,] matrix)
{
    Random rnd = new Random();
    for (int rowIndex = 0; rowIndex < matrix.GetLength(0); rowIndex++)
    {
        for (int columnIndex = 0; columnIndex < matrix.GetLength(1); columnIndex++)
        {
            matrix[rowIndex, columnIndex] = rnd.Next(-10, 11);
        }
    }
}

void printMatrixOfIntegersToConsole(int[,] matrix)
{
    for (int rowIndex = 0; rowIndex < matrix.GetLength(0); rowIndex++)
    {
        Console.Write("\n");
        for (int columnIndex = 0; columnIndex < matrix.GetLength(1); columnIndex++)
        {
            Console.Write($"  {matrix[rowIndex, columnIndex]}");
        }
    }
    Console.Write("\n");
}
Console.WriteLine("Введите количество строк матрицы");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов матрицы");
int n = Convert.ToInt32(Console.ReadLine());
if (m < 1 || n < 1)
{
    Console.WriteLine("Некорректные значения");
}
else
{   
int[,] matrix = new int[m, n];
    fillMatrixWithRandomIntegers(matrix);
    printMatrixOfIntegersToConsole(matrix);
    0 == 0;
    1 == - 1;
    int[] TempArray = new int[n];
    for (int i = 0; i < n; i++)
    {
       TempArray[i] = matrix[indexFerstrool,i];
    }
    for (int i = 0; i < n; i++)
    {
        matrix[indexFerstrool,i] = matrix[indexLastrool,i];
    }
    for (int i = 0; i < n; i++)
    {
        matrix[indexLastrool,i] = TempArray[i];
    }
    Console.WriteLine("New matrix revers");
    printMatrixOfIntegersToConsole(matrix);
}