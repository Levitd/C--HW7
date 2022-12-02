using System;
using static System.Console;

Clear();


// Задача 47
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
try
{
    Write("Введите размер массива через пробел: ");
    string[] nums = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    double[,] array = GetArray(Convert.ToInt32(nums[0]), Convert.ToInt32(nums[1]), -10, 10);

    Print2DArray(array);

}
catch (OverflowException)
{
    Write("Переполнение! Ввели слишком большое число!");
}
catch (FormatException)
{
    Write("Ожидалось число!");
}
catch
{
    Write("Ошибка выполнения!");
}

//Создание двумерного массива 
double[,] GetArray(int rows, int colums, int min, int max)
{
    double[,] result = new double[rows, colums];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = Math.Round((new Random().Next(min, max + 1)) + (new Random().NextDouble()), 2);
        }
    }
    return result;
}
//Печать двумерного массива
void Print2DArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{(inArray[i, j].ToString().PadLeft(5, ' ')):f} ");
        }
        WriteLine();
    }
    WriteLine();
}

*/
//---------------------------------------------------------------------------------------


// Задача 50
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

/*
try
{
    Write("Введите размер массива через пробел: ");
    string[] nums = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    double[,] array = GetArray(Convert.ToInt32(nums[0]), Convert.ToInt32(nums[1]), -10, 10);

    Write($"Введите позицию искомого элемента i (от 0 до {Convert.ToInt32(nums[0])-1}) j (от 0 до {Convert.ToInt32(nums[1])-1}) , через пробел : ");
    string[] foundElement = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] arrayElement = new int[] { Convert.ToInt32(foundElement[0]), Convert.ToInt32(foundElement[1]) };

    PrintArray(array);

    double[] element = GetFoundElementInArray(array, arrayElement);

    if (element[0] > 0)
    {
        Write($"Значение искомого элемента: {element[1]}");
    }
    else
    {
        Write("По указанным координатм элемента в масиве нет!");
    }

}
catch (OverflowException)
{
    Write("Переполнение! Ввели слишком большое число!");
}
catch (FormatException)
{
    Write("Ожидалось число!");
}
catch
{
    Write("Ошибка выполнения!");
}
double[] GetFoundElementInArray(double[,] inArray, int[] element)
{
    double[] result = new double[2];
    if (element[0] < inArray.GetLength(0)
        && element[1] < inArray.GetLength(1))
    {
        result[0] = 1;
        result[1] = inArray[element[0], element[1]];
    }
    else
    {
        result[0] = -1;
    }
    return result;
}
//Создание двумерного массива 
double[,] GetArray(int rows, int colums, int min, int max)
{
    double[,] result = new double[rows, colums];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = Math.Round((new Random().Next(min, max + 1)) + (new Random().NextDouble()), 2);
        }
    }
    return result;
}
//Печать двумерного массива
void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j].ToString().PadLeft(5, ' ')} ");
        }
        WriteLine();
    }
}
*/
//----------------------------------------------------------


// Задача 52
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


try
{
    Write("Введите размер массива через пробел: ");
    string[] nums = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[,] array = GetArray(int.Parse(nums[0]), int.Parse(nums[1]), 0, 10);

    PrintArrayTwo(array);

    double[] sumColumsSrednee = GetSumColumsSrednee(array);
    WriteLine();
    PrintArray(sumColumsSrednee);

}
catch (OverflowException)
{
    Write("Переполнение! Ввели слишком большое число!");
}
catch (FormatException)
{
    Write("Ожидалось число! Ввели непонять что!");
}
catch
{
    Write("Ошибка выполнения!");
}

//Создание двумерного массива 
int[,] GetArray(int rows, int colums, int min, int max)
{
    int[,] result = new int[rows, colums];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }
    }
    return result;
}
//Печать двумерного массива
void PrintArrayTwo(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j].ToString().PadLeft(5, ' ')} ");
        }
        WriteLine();
    }
}
//Печать одномерного массива с форматированием
void PrintArray(double[] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        Write($"{Math.Round(inArray[i], 2).ToString().PadLeft(5, ' ')} ");
    }
}

double[] GetSumColumsSrednee(int[,] inArray)
{
    double[] result = new double[inArray.GetLength(1)];
    // не стал менять привычный порядок обхода массива, проходя по строке накапливаю сумму в результирующем масссиве в нужном индексе result[j]
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            result[j] += inArray[i, j];
        }
    }
    // сумму по колонке / на кол-во строк
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = result[i] / inArray.GetLength(0);
    }
    return result;
}
