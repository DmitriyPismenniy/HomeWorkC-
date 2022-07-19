//Zadacha25
//Цикл принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵) ; 2, 4 -> 16

//Zadacha27
//Введите число число и выдайте сумму цифр в числе
//452 -> 11 ; 82 -> 10 ; 9012 -> 12

//Zadacha29
//Программа задаёт массив из 8 элементов и выводит отсортированный по модулю массив.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] ; 6, 1, 33 -> [6, 1, 33]

void Zadacha25()
{
    Console.Write("Введите количество шагов цикла: ");
    int step = Convert.ToInt32(Console.ReadLine());    
    Random rand = new Random();
    double pow = 1;
    
    for (int i = 0; i < step; i++)
    {
        int a = rand.Next(1, 10);
        int b = rand.Next(1, 10);
        pow = Math.Pow(a, b);
        Console.WriteLine($"Power({a},{b}) = {pow}");
    }
}

void Zadacha27()
{
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int result = number;
    int digit = 0;
    int sum = 0;
    
    while (result != 0)
    {
        result /= 10;
        digit++;
    }

    result = 1;
    for (int i = 0; i < digit; i++)
    {
        sum += ((number / result) % 10);
        result *= 10; 
    }
    Console.WriteLine("Сумма цифр числа = " + sum);
    
}

void Zadacha29Bubble()
{
    Random rand = new Random();
    int[] array = new int[8];
    int help = 0;

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(-10, 11);
    }

    Console.Write("Исходный массив        - ");
    PrintArray(array);

    for (int j = array.Length; j > 0; j--)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (Math.Abs(array[i]) > Math.Abs(array[i+1]))
            {
                help = array[i+1];
                array[i+1] = array[i];
                array[i] = help;             
            }
        }
    }

    Console.Write("Отсортированный массив - ");
    PrintArray(array);
}

void Zadacha29Insert()
{
    Random rand = new Random();
    int[] array = new int[8];
    int help = 0;

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(-10, 11);
    }

    Console.Write("Исходный массив        - ");
    PrintArray(array);
    
    int cell = 1;
    while (cell < array.Length)
    {

        for (int i = 0; i < cell; i++)
        {
            if (Math.Abs(array[cell]) < Math.Abs(array[i]))
                {
                    help = array[cell];                    
                    array[cell] = array[i];
                    array[i] = help;             
                }
        }
    cell++;
    }

    Console.Write("Отсортированный массив - ");
    PrintArray(array);

    

    

}

void PrintArray(int[] array)
{
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]}, ");
        }
        Console.Write("\b\b.");
        Console.WriteLine();
}


Zadacha25();
Zadacha27();
Zadacha29Bubble();
Zadacha29Insert();