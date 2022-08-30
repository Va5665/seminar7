// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());


int[,] GetArray(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++) // по строчкам
    {
        // i, j, m, k
        for (int j = 0; j < matrix.GetLength(1); j++) // по столбцам
        {
            matrix[i, j] = new Random().Next(11); // [0;10]
        }
    }
    return matrix;
}
int[,] resultMatrix = GetArray(rows, columns);
PrintArray(resultMatrix);

void PrintArray(int[,] inputMatrix)
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
int[,] matrix = resultMatrix;


       for (int j = 0; j < matrix.GetLength(1); j++)

    {
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i,j];
        }
        var Av = sum / matrix.GetLength(1);
        Console.Write($" среднее арифметическое -> {Av}, ");
        
    }



    
          
