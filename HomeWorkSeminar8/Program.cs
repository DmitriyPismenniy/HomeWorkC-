/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по 
убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2

Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей 
суммой элементов: 1 строка

Задача 58. Заполните спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
1   2   3   4
12  13  14  5
11  16  15  6
10  9   8   7
*/

void Zadacha54()
{
    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    int[,] array = new int[rows, columns];
    FillArrayInt(array); 
    Console.WriteLine("Исходный массив: ");
    PrintArrayInt(array);
    Console.WriteLine("Отсортированный по строкам массив: ");

    for (int i = 0; i < rows; i++)
    {
        for (int j = columns; j > 0; j--)
        {
            for (int k = 0; k < columns - 1; k++)
            {
                if (array[i, k] > array[i, k+1])
                {
                    int help = array[i, k+1];
                    array[i, k+1] = array[i, k];
                    array[i, k] = help;             
                }
            }
        }
    }
    
    PrintArrayInt(array);
    Console.WriteLine();


}

void Zadacha56()
{
    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    int[,] array = new int[rows, columns];
    int[] arraysum = new int[rows]; 
    FillArrayInt(array); 
    Console.WriteLine("Исходный массив: ");
    PrintArrayInt(array);
    
    for (int i = 0; i < rows; i++)
    {
        int sum = 0;
        for (int j = 0; j < columns; j++)
        {
            sum += array[i, j];
        }
        arraysum[i] = sum;
        Console.Write($"Сумма строки {i+1} равна {arraysum[i]}");
        Console.WriteLine();
    }     

    int index = 0;
    int MinSum = arraysum[0];
    for (int i = 0; i < rows; i++)
    {
        if (arraysum[i] < MinSum) 
        {
            MinSum = arraysum[i];
            index = i;
        }
    } 
    Console.WriteLine($"Номер строки с наименьшей суммой элементов равен  {index + 1}");
}


void Zadacha58()
{
    int rows = 4;
    int columns = 4;
    int[,] array = new int[rows, columns];
    int i = 0;
    int j = 0;
       
        for (int k = 0; k < rows * columns; k++)
        {    
            if (k == 0)
            {
                array[i, j] = k + 1;
            }  
             
            if (k > 0 && k < 4)
            {
                j++;
                array[i, j] = k + 1;
            }
            if (k > 3 && k < 7)
            {
                i++;
                array[i, j] = k + 1;
            }
            if (k > 6 && k < 10)
            {
                j--;
                array[i, j] = k + 1;
            }
            if (k > 9 && k < 12)
            {
                i--;
                array[i, j] = k + 1;
            }
             if (k > 11 && k < 14)
            {
                j++;
                array[i, j] = k + 1;
            } 
             if (k > 13 && k < 15)
            {
                i++;
                array[i, j] = k + 1;
            } 
             if (k == 15)
            {
                j--;
                array[i, j] = k + 1;
            }
        }    
    PrintArrayInt(array);
    Console.WriteLine();  
}



void Zadacha58FromNet()
{
    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    int[,] array = new int[rows, columns];
    int ibeg = 0;
    int ifin = 0;
    int jbeg = 0;
    int jfin = 0;
    int k = 1;
    int i = 0;
    int j = 0;

    while (k <= rows * columns)
    {
        array[i, j] = k;
        if (i == ibeg && j < columns - jfin - 1)
        j++;
        else if (j == columns - jfin -1 && i < rows - ifin - 1) 
        i++;
        else if (i == rows - ifin -1 && j > jbeg)
        j--;
        else i--;
    
        if ((i == ibeg +1) && (j == jbeg) && (jbeg != columns - jfin - 1))
        {
            ibeg++;
            ifin++;
            jbeg++;
            jfin++;
        }
        k++;
    }


    PrintArrayInt(array);
    Console.WriteLine();  
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

//Zadacha54();
//Zadacha56();
//Zadacha58();
Zadacha58FromNet();