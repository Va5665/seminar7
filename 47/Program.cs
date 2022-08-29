// 47.
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


Console.Write("Введите количество строк: ");
var rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
var columns = Convert.ToInt32(Console.ReadLine());
double[,] GetArray(int m, int n)
{
    double[,] matrix = new double[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++) // по строчкам
    {

        for (int j = 0; j < matrix.GetLength(1); j++) // по столбцам
        {
            matrix[i, j] = new Random().Next(-100, 100) / 10.0;
        }
    }
    return matrix;
}
double[,] resultMatrix = GetArray(rows, columns);
PrintArray(resultMatrix);


void PrintArray(double[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            Console.Write(inputMatrix[i, j] + "\t"); // "\t" - Tab
        }
        Console.WriteLine();
    }
}
