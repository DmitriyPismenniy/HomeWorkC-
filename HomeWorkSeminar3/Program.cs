//Zadacha19 
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет ; 12821 -> да  ;  23432 -> да

//Zadacha21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84  ;  A (7,-5, 0); B (1,-1,9) -> 11.53

//Zadacha23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27  ; 5 -> 1, 8, 27, 64, 125

void Zadacha19()
{
    Console.Write("Введите пятизначное число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int firstpart = number / 1000;
    int secondpart = ((number % 10) * 10) + (number / 10 % 10);

    if (firstpart == secondpart)
    {
        Console.WriteLine("Данное число является палиндромом");
    }
    else
    {
        Console.WriteLine("Данное число не является палиндромом");
    }    
}

void Z19ForAnyNumber()
{   
    Console.Write("Введите любое целое число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int number1 = 0;
    int result = number;
    int digit = 0;

    while (result != 0)
        {
            result /= 10;
            digit++;                    
        }
    
    result = 1; 
    int level = (int)Math.Pow(10, (digit-1));       
    for (int i = 0; i < digit; i++)
    {
        number1 += (number / result) % 10 * level;
        result *= 10;
        level /=10;                     
    }
    
    if (number == number1)
        {
            Console.WriteLine("Число является палиндромом");
        }
        else Console.WriteLine("Число не является палиндромом");
}            

void Z19ForAnyNumberString()
{
    Console.Write("Введите число: ");
    string s = Console.ReadLine();
    string s1 = ""; 

    if (s[0] != '-')
    {
        for (int i = s.Length - 1; i > -1; --i)
         s1 += (s[i]);         
    }
    else
    {
        s1 = "-";        
        for (int i = s.Length - 1; i > 0; --i)
            s1 += (s[i]);
    }
    
    if (s == s1)
    {
        Console.WriteLine("Число является палиндромом");
    }
    else Console.WriteLine("Число не является палиндромом");
}

void Z19StringToNumber()
{
    Console.Write("Введите положительное целое число: ");
    string s = Console.ReadLine();
    int number = 0;
    int result = Power(number);
    Console.WriteLine("Число равно " + result);
    result -= 1;
    Console.WriteLine("Число -1 равно " + result);
    
    //Процедура преобразования строки в число
    int Power(int number)
    {
        int d = 0;
        int level = s.Length - 1;
        for (int i = 0; i < s.Length; i++)
        {
        int a = (int)(s[d]);
        number += ((a-48)* (int)Math.Pow(10, level));
        level -=1;     
        d++;
        }    
    return (number);
    }            
}

void Zadacha21()
{
    Console.WriteLine("Введите координаты первой точки:");
    Console.Write("x1 = ");
    int x1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("y1 = ");
    int y1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("z1 = ");
    int z1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координаты второй точки:");
    Console.Write("x2 = ");
    int x2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("y2 = ");
    int y2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("z2 = ");
    int z2 = Convert.ToInt32(Console.ReadLine());
    
    double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
    Console.WriteLine($"Расстояние между точками {Math.Round(result, 2)}");

}

void Zadacha23()
{
    Console.Write("Введите положительное целое число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int d = 1;
    int kub = 1;

    for (int i = 0; i < number; i++)
    {
        kub = (int)Math.Pow(d, 3);
        Console.WriteLine($"| {d} | {kub} |");
        d++;
    }
}




//Zadacha19();
//Z19ForAnyNumber();
//Z19ForAnyNumberString();
//Z19StringToNumber();
//Zadacha21();
Zadacha23();
