// Задайте значение N. Напишите программу, которая выведет все натуральные
// числа в промежутке от N до 1. Выполнить с помощью рекурсии.

int n = InputInt("Введите  число: ");
int m = 1;

Console.WriteLine(NaturalNum(n, m));

int NaturalNum(int n, int m)
{
    if (n == m)
        return n;
    else
        Console.Write($"{NaturalNum(n, m + 1)}, ");
    return m;
}

int InputInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}