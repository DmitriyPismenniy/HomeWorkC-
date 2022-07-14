//Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

void Zadacha15()
{
    Console.Write("Введите число от 1 до 7, обозначающее день недели: ");
    int number = Convert.ToInt32(Console.ReadLine());

    if (number > 0 && number < 8)
    {
        if (number == 6 || number == 7)
        {
            Console.WriteLine("Выходной");
        }
        else Console.WriteLine("Рабочий");
    }
    else Console.WriteLine("Неверный формат");
}

Zadacha15();


    
 

