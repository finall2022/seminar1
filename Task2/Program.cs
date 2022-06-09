/* Напишите программу, которая выводит
случайное число из отрезка [10, 99] и показывает
наибольшую цифру числа.
78 -> 8
12-> 2
85 -> 8 */
int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка {number}");
int x = number % 10;
int y = number / 10;
if (x > y)
{
    Console.WriteLine($"Большая вторая цифра {x}");
}
else if (y < x)
    {
    Console.WriteLine($"Большая первая цифра {y}");
    }
    else{
        Console.Write($"Оба числа равны {x}");
    }