//Программа, которая на вход принимает число и выдает, является ли число четным.

Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    Console.Write("ДА! Число четное");
}
else
{
    Console.Write("НЕТ! Число нечетное");
}