//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите первое число: ");
string number = Console.ReadLine()!;
int num1 = int.Parse(number);

Console.Write("Введите второе число: ");
number = Console.ReadLine()!;
int num2 = int.Parse(number);

int min = 0, max = 0;
if (num1 > num2)
{
    max = num1;
    min = num2;
    Console.WriteLine($"Большее - {max}.");
    Console.WriteLine($"Меньшее - {min}.");
}
else if (num1 < num2)
{
    max = num2;
    min = num1;
    Console.WriteLine($"Большее - {max}.");
    Console.WriteLine($"Меньшее - {min}.");
}
else
{
    Console.WriteLine("Числа равны.");
}

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.


//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).


//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.