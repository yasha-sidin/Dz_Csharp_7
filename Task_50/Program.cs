// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает
// значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Напечатать двумерный массив
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

// Проверяем есть ли заданное пользователем число в двухмерном массиве
string CheckNumberInTableArray(int number, int[,]tableArray)
{
    int rows = tableArray.GetLength(0);
    int columns = tableArray.GetLength(1);
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            if(number == tableArray[i, j])
            {
                string result = $"Число {number} есть в массиве";
                return result;
            }
        }
    }
    string badResult = $"Числа {number} нет в массиве";
    return badResult;
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

Console.Write("Напишите число, которое хотите найти в массиве: ");
int numberCheck = int.Parse(Console.ReadLine());
Console.WriteLine(CheckNumberInTableArray(numberCheck, tableArray));