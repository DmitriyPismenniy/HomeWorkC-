//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
//стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным 
//элементов массива.
//[3,21 7,04 22,93 -2,71 78,24] -> 75,53

void Zadacha34()
{
    int size = 10;
    int[] array = new int[size];
    Random random = new Random();
    int count = 0;

    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(100, 1000);
    }

    for (int i=0; i < size; i++)
    {
        Console.Write(array[i] + " ");
    }
    
    for (int i = 0; i < size; i++)
    {
        if(array[i]%2 == 0)
        {
            count += 1;
        }
    }
    Console.Write($"->  {count}");
    Console.WriteLine();

}

void Zadacha36()
{
    int size = 10;
    int sum = 0;
    int[] array = new int[size];
    Random random = new Random();

    for (int i=0; i < size; i++)
    {
        array[i] = random.Next(1, 10);
    }

    for (int i=0; i < size; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();  

    for (int i = 1; i < size; i = i + 2)
    {
        sum += array[i];
    }

    Console.WriteLine($"Сумма элементов с нечетными индексами равна {sum}");
}

void Zadacha38()
{
    int size =10;
    int sum =0;
    double[] array = new double[size];
    Random random = new Random();

    for (int i=0; i < size; i++)
    {
        array[i] = Convert.ToDouble(random.Next(1000, 10000))/10;        
    }


    for (int i=0; i < size; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine(); 

    double min = array[0];
    double max = array[0];
    for (int i=0; i < size; i++)
    {
        if (array[i] > max) max = array[i];
        else if (array[i] < min) min = array[i];
    }
    Console.WriteLine($"Максимальное число = {max}, Минимальное число = {min}, Разница = {max-min}"); 
}


//Zadacha34();
//Zadacha36();
//Zadacha38();