// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void PrintIntTableArray(int[,] tableArray)
{
    int rows = tableArray.GetLength(0);
    int columns = tableArray.GetLength(1);
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            if(j == tableArray.GetLength(1) - 1)
            {
                Console.WriteLine($"{tableArray[i, j]}");
                break;
            }
            Console.Write($"{tableArray[i, j]}, ");
        }
    }
}

// -----------------------------------------------------------------------------------------

// Заполнить двумерный массив случайными числами
int[,] FillIntTableArray(int[,] tableArray, int startRange, int endRange)
{
    int rows = tableArray.GetLength(0);
    int columns = tableArray.GetLength(1);
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            tableArray[i, j] = new Random().Next(startRange, endRange + 1);
        }
    }

    return tableArray;
}

// -----------------------------------------------------------------------------------------

// Находи среднее арифметическое каждого столбца двумерного массива
void ArithmeticMeanOfColumnsOfTableArray(int[,] tableArray)
{
    int rows = tableArray.GetLength(0);
    int columns = tableArray.GetLength(1);
    double sum = 0;
    double arr = 0;
    for(int i = 0; i < columns; i++)
    {
        for(int j = 0; j < rows; j++)
        {
            sum += tableArray[j, i];
        }
        arr = Math.Round((sum / rows), 1);
        Console.WriteLine($"Среднее арифметическое {i + 1} столбца = {arr}");
    }
}

// -----------------------------------------------------------------------------------------

Console.Clear();
Console.Write("Количество строк массива (m): ");
int m = int.Parse(Console.ReadLine());
Console.Write("Количество столбцов массива (m): ");
int n = int.Parse(Console.ReadLine());

int[,] tableArray = new int[m, n];

FillIntTableArray(tableArray, 0, 100);
PrintIntTableArray(tableArray);
Console.WriteLine();

ArithmeticMeanOfColumnsOfTableArray(tableArray);