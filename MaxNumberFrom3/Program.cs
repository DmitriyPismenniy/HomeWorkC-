// Программа нахождения максимального из трех чисел
Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int numberС = Convert.ToInt32(Console.ReadLine());


if (numberA > numberB)
    {
        if (numberA > numberС)
        {
                Console.WriteLine("Максимальное из трех чисел: " + numberA); 
        }
        else
        {
                Console.WriteLine("Максимальное из трех чисел: " + numberС);
        }
    }
    else
    {
        if (numberB > numberС)
       {
            Console.WriteLine("Максимальное из трех чисел: " + numberB); 
       }
       else
       {
           Console.WriteLine("Максимальное из трех чисел: " + numberС);
       }
    }
