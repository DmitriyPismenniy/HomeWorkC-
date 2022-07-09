// Программа нахождения максимального из двух чисел
Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
    {
       Console.WriteLine("Максимальное из двух чисел: " + numberA); 
    }
    else
    {
        Console.WriteLine("Максимальное из двух чисел: " + numberB);
    }