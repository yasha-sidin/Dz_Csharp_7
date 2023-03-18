// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Напечатать двумерный массив вещественных чисел
void PrintDoubleTableArray(double[,] tableArray)
{
    int rows = tableArray.GetLength(0);
    int columns = tableArray.GetLength(1);
    Console.Write("[");
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            if(i == rows - 1 && j == columns - 1)
            {
                Console.Write($"{tableArray[i, j]}");
                break;
            }
            if(j == columns - 1)
            {
                Console.WriteLine($"{tableArray[i, j]};");
                break;
            }
            Console.Write($"{tableArray[i, j]}; ");
        }
    }
    Console.WriteLine("]");
}

// -----------------------------------------------------------------------------------------

// Заполнить двумерный массив случайными числами
double[,] FillDoubleTableArray(double[,] tableArray)
{
    int rows = tableArray.GetLength(0);
    int columns = tableArray.GetLength(1);
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            int random = new Random().Next(0, 2);
            if(random == 0)
            {
                tableArray[i, j] = Math.Round((new Random().NextDouble() * new Random().Next(10, 1000)), 2);
            }
            if(random == 1)
            {
                tableArray[i, j] = Math.Round((new Random().NextDouble() * new Random().Next(-1000, -10)), 2);
            }
        }
    }

    return tableArray;
}

// -----------------------------------------------------------------------------------------

Console.Clear();
Console.Write("Количество строк массива (m): ");
int m = int.Parse(Console.ReadLine());
Console.Write("Количество столбцов массива (m): ");
int n = int.Parse(Console.ReadLine());

double[,] tableArray = new double[m, n];

FillDoubleTableArray(tableArray);
PrintDoubleTableArray(tableArray);