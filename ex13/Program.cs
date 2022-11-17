// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите целое число: ");
int n = Convert.ToInt32(Console.ReadLine());

int DigitFind(int n)
{
    int result = -1;
    if (n >= 100)
    {
        while (n > 999)
        {
            n = n / 10;
        }
        result = n % 10;
    }
    return result;
}

if (DigitFind(n) == -1)
{
Console.WriteLine($"{n} -> третьей цифры не существут");
}
else
{
Console.WriteLine($"{n} -> {DigitFind(n)}");
}
