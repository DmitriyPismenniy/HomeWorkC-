// Программа нахождения всех четных чисел от 1 до N
Console.WriteLine("Введите положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;

while (count != (number +1))
{
    if (count % 2 == 0)
        {
        Console.Write(count + ",");
        }
    count++;         
}
Console.Write("\b.");
Console.WriteLine(); 

