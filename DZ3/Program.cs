// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным

Console.Write("Ввелите цифруо дня недели: ");
int Number = Convert.ToInt32(Console.ReadLine());

if ((Number > 0) & (Number <= 7))
{
    if ((Number >= 6) & (Number <= 7))
    {
        Console.WriteLine("Данный день недели выходной");
    }
    else
    {
        Console.WriteLine("Данный день недели не является выходным");
    }
}
else
{
    Console.WriteLine("Введеная цифра не является днем недели");
}