//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов 
//в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void Zadacha47()
{
    int m = 3;
    int n = 4;
    double[,] array = new double[m, n];
    FillArrayDouble(array, 5, 10);
    PrintArrayDouble(array);
    Console.WriteLine();
}

void Zadacha47Random()
{
    Random random = new Random();
    int rows = random.Next(4, 8);
    int colums = random.Next(4, 8);
    double[,] array = new double[rows, colums];
    FillArrayDouble(array, 50, 100);
    PrintArrayDouble(array);
    Console.WriteLine();
}

void Zadacha50()
{
    Random random = new Random();
    int rows = random.Next(4, 8);
    int colums = random.Next(4, 8);
    int[,] array = new int[rows, colums];
    FillArrayInt(array);
    PrintArrayInt(array);
    Console.Write("Введите номер строки: ");//Для пользователя от 1...
    int row = Convert.ToInt32(Console.ReadLine());    
    Console.Write("Введите номер столбца: ");//Для пользователя от 1...
    int column = Convert.ToInt32(Console.ReadLine());
    if (row - 1 < array.GetLength(0) && column - 1 < array.GetLength(1))
    {
        Console.WriteLine($"Значение элемента массива в {row} строке и {column} столбце равно {array[row - 1, column - 1]}");

    }
    else Console.WriteLine($"Значение элемента массива в {row} строке и {column} столбце не существует");

}

void Zadacha52()
{
    Random random = new Random();
    int rows = random.Next(4, 8);
    int colums = random.Next(4, 8);
    int[,] array = new int[rows, colums];
    FillArrayInt(array);
    PrintArrayInt(array);
    Console.WriteLine();
    
    for (int j = 0; j < colums; j++)
    {
        double sum = 0;
        for (int i = 0; i < rows; i++)
        {
            sum += array[i,j]; 
        }
        double avr = Math.Round(sum / rows, 2);
        Console.WriteLine($"Сумма элементов {j+1} столбца = {sum}; Среднее арифметическое столбца = {avr}");
    }  
    Console.WriteLine(); 

}

void FillArrayDouble(double[,] array, int startNumber = 0, int finishNumber = 10)
{
    finishNumber++;
    Random random = new Random();
    int rows = array.GetLength(0);
    int colums = array.GetLength(1);
    for (int i=0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            array[i,j] = Math.Round(random.NextDouble() * finishNumber - startNumber, 2);
        }
    }
}

void PrintArrayDouble(double[,] array, int startNumber = 0, int finishNumber = 10)
{
    int rows = array.GetLength(0);
    int colums = array.GetLength(1);
    for (int i=0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

void FillArrayInt(int[,] array, int startNumber = 0, int finishNumber = 10)
{
    finishNumber++;
    Random random = new Random();
    int rows = array.GetLength(0);
    int colums = array.GetLength(1);
    for (int i=0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            array[i,j] = random.Next(startNumber, finishNumber);
        }
    }
}

void PrintArrayInt(int[,] array, int startNumber = 0, int finishNumber = 10)
{
    int rows = array.GetLength(0);
    int colums = array.GetLength(1);
    for (int i=0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
}



//Zadacha47();
//Zadacha47Random();
//Zadacha50();
Zadacha52();

