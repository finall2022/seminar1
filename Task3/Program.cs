/* Напишите программу, которая будет принимать на
вход два числа и выводить, является ли второе число
кратным первому. Если число 2 не кратно числу 1, то
программа выводит остаток от деление.
34, 5 -> не кратно, остаток 4
16, 4 -> кратно */
Console.WriteLine("Программа проверики второго числа на кратность первому");
Console.Write("Введите первое число: ");
string inum1 = Console.ReadLine();
Console.Write("Введите второе число: ");
string inum2 = Console.ReadLine();
int num1 = int.Parse(inum1);
int num2 = int.Parse(inum2);
if (num1 % num2 == 0)
{
    Console.WriteLine($"Число {num2} кратно {num1} ");
}
else
{
    float ostatok = num1 % num2;
    Console.WriteLine($"Число {num2} не кратно {num1}, остаток: {ostatok} ");
}