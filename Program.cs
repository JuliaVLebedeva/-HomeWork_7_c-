//Урок 7. Как не нужно писать код. Часть 1


void Zadacha47()
{ 
            
            //Урок 7. Как не нужно писать код. Часть 1
            //Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

            Random random = new Random();
            int rows = random.Next(4, 8);
            int columns = random.Next(4, 8);
            double[,] array = new double[rows, columns];
            FillArray(array);
            PrintArray(array);


            static void FillArray(double[,] array, int startNumber = 0, int finishNumber = 10)
            {
                int rows = array.GetLength(0);
                int columns = array.GetLength(1);
                Random random = new Random();
                finishNumber++;
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        array[i, j] = Math.Round(random.NextDouble() * 10 - 5);
                    }
                }
            }

            static void PrintArray(double[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write(array[i, j] + "\t");
                    }
                    Console.WriteLine(" ");
                }
            }
}
//Zadacha47();


void Zadacha50()
{ 
    // Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    int[,] array = new int[rows, columns];
    FillArray(array);
    PrintArray(array);

    Console.WriteLine("Номер строки");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Номер столбца");
    int column = Convert.ToInt32(Console.ReadLine());

    if (row <= rows && row > 0 && column <= columns && column > 0)
    {
       Console.WriteLine($"Искомые элементы {array[row - 1, column - 1]}");
    }
    else
    {
        Console.WriteLine("Элемента не существует");
    }
}


//Zadacha50();

void Zadacha52()
{
    // Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
    Random random = new Random();
    int rows = 3;
    int columns = 5;
    int[,] array = new int[rows, columns];
    FillArray(array, 0, 10);
    PrintArray(array);
    Console.WriteLine();
    for (int j = 0; j < columns; j++)
    {
        double sum = 0;    
        for (int i = 0; i < rows; i++)
        {
            sum += array[i, j];
        }
         Console.Write(Math.Round(sum/rows, 2) + "\t");
    }
}
//Zadacha52();

static void FillArray(int[,] array, int startNumber = 0, int finishNumber = 10)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    Random random = new Random();
    finishNumber++;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(startNumber, finishNumber);
        }
    }
}

static void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine(" ");
    }
}




