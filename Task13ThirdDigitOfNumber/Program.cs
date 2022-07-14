// Программа нахождения третьей цифры целого числа
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

void Zadacha13()
{
    // Ввод числа и определение переменных
    Console.Write("Введите любое целое число: ");
    int number = Convert.ToInt32(Console.ReadLine());

    int result = number;
    int count = 1;
    int digit = 0;

    // Определение количества цифр в числе
    while (result != 0)
        {
            result = result / 10;
            digit++;                    
        }

    Console.WriteLine($"Количество цифр в числе = {digit}");

    //Уменьшение числа до трёхзначного и вычисление третьей цифры числа
    if (digit > 2)
        {
            while (digit > 3)
            {
                count = count *10; 
                digit--;
            }
            result = Math.Abs((number / count) % 10);
            Console.WriteLine($"Третья цифра = {result}");        
        }
        else Console.WriteLine("Третьей цифры нет");
}

Zadacha13();


    
 
