// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите цифру обозначающую день недели: ");
int date = int.Parse(Console.ReadLine());

if (date == 6 || date == 7)
{
    Console.Write($"{date} -> да, выходной день");
}
else if (date < 1 || date > 7)
{
    Console.Write($"{date} -> вы ввели несуществующий день недели");
}
else
{
    Console.Write($"{date} -> нет, рабочий день");
}


