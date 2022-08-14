//Программа, которая на вход принимает два числа и выдает, какое число большее.

Console.WriteLine("Введите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    Console.Write("Максимальное число: ");
    Console.Write(number1);
}
else
{
    Console.Write("Максимальное число: ");
    Console.Write(number2);
}