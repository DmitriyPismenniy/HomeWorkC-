//Задача 1. Пользователь вводит число N (N > 0). Программа должна вывести N единиц на экран.
//N = 4 -> 1, 1, 1, 1 ; N = 2 -> 1, 1

//Задача 2. Даны два числа a, b, такие что a < b. Вывести на экран сколько раз число a поместиться 
//в числе b.

//Задача 3. На ввод подаётся рост трёх спортсменов. Расположить их от большего к меньшему.

//Задача 4. Дано N секунд. Вывести время в формате часы:минуты:секунды.
//N = 72334 -> 20:5:34 

void Zadacha1()
{
    Console.Write("Введите положительное число N > 0: ");
    int number = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < number; i++)
    {
        Console.Write("1, ");
    } 
    Console.Write("\b\b ");
    Console.WriteLine();
}

void Zadacha2()
{
    Console.Write("Введите число а: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    Console.Write("Введите число b > a: ");
    int b = Convert.ToInt32(Console.ReadLine());
    int count = 0;
    int div = b;

    while (div > 0)
    {
        div /= a;
        count++; 
    } 
    Console.WriteLine($"Число а помещается в числе b {count} раз");
}

void Zadacha3()
{
    Console.Write("Введите рост первого спортсмена в см: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите рост второго спортсмена в см: ");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите рост третьего спортсмена в см: ");
    int c = Convert.ToInt32(Console.ReadLine());
    int max = a;
    int middle = a;
    int min = a;

    if (b > a) 
    {
        max = b;
    }
    else 
    {
        min = b;
    }      

    if (c > max)
    {
        middle = max;
        max = c;
    }
    else if (c < min)
            {
                middle = min;
                min = c;
            }
            else 
            {
                middle = c;
            }
    Console.WriteLine($"max= {max}; middle= {middle}; min= {min}");        
}

void Zadacha4()
{
    Console.Write("Введите время в секундах: ");
    int number = Convert.ToInt32(Console.ReadLine());
    
    int hour = number / 3600;
    int minute = (number % 3600) / 60;
    int second = number - hour * 3600 - minute * 60;
    Console.WriteLine($"{hour}:{minute}:{second}");
}

//Zadacha1();
//Zadacha2();
//Zadacha3();
Zadacha4();