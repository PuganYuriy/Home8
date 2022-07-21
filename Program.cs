// Урок 8. Как не нужно писать код. Часть 2
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

int [,] generateRandomArray(int z, int x, int minNumber, int maxNumber) // создание функции для создания двухмерного массива
{
    int [,] rnArray = new int [z, x];
    for (int i = 0; i < z; i++)
    {
        for (int j = 0; j < x; j++)
        {
            rnArray[i, j] = new Random().Next(minNumber, maxNumber+1); //заполнение массива случайными числами
        }
    }
    return rnArray;
}

void printArray(int [,] prArray) // создание метода для вывода массива на консоль
{
    for (int i = 0; i < prArray.GetLength(0); i++)
    {
        for (int j = 0; j < prArray.GetLength(1); j++)
        {
            Console.Write($"{prArray[i, j]} ");
        }
    Console.WriteLine(" ");
    }
}

void sortingArray(int [,] soArray) // создание метода для сортировки массива
{
    for (int i = 0; i < soArray.GetLength(0); i++)
    {
        for (int j = 0; j < soArray.GetLength(1); j++)
        {
            for (int t = j+1; t < soArray.GetLength(1); t++)
            {
                if (soArray[i, t] > soArray[i, j])
                {
                int temp = soArray[i, j];
                soArray[i, j] = soArray[i, t];
                soArray[i, t] = temp;   
                }
            }
        }
    }
}

Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows=Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns=Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное число массива: ");
int min=Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное число массива: ");
int max=Convert.ToInt32(Console.ReadLine());

int [,] array = generateRandomArray (rows, columns, min, max);
printArray(array);
Console.WriteLine("--------------------");
sortingArray(array);
printArray(array);


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7



// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2              1 5 8 5
// 5 9 2 3              4 9 4 2
// 8 4 2 4              7 2 2 6
// 5 2 6 7              2 3 4 7




// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49




// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)




// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7
