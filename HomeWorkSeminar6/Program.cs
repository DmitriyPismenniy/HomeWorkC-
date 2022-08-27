//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 
//ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных 
//уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)



void Zadacha41()
{
    int count = 0;
    Console.WriteLine("Сколько чисел требуется ввести?");
    int m = Convert.ToInt32(Console.ReadLine());
    for (int i=0; i < m; i++)
    {
        Console.Write($"Введите {i+1} число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number > 0) count++;
    }
    Console.WriteLine("Было введено чисел больше нуля: " + count);
}

void Zadacha43()
{
    int k1 = 0;
    int b1 = 2;
    int k2 = 1;
    int b2 = 1;

    if (k1==k2)
    {
        Console.WriteLine("прямые параллельны, точек пересечения нет ");
    }
    else
    {
        double x = (b2-b1)/(k1-k2);
        double y = k1*x +b1;
        double y2 = k2*x+b2;
        Console.WriteLine($"Прямые пересекаются в точке А({x},{y})");
        Console.WriteLine($"Прямые пересекаются в точке А({x},{y2})");
    }

}


//Zadacha41();
//Zadacha43();