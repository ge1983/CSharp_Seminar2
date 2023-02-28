// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int Number=1;

while (Number <=100) 
{
    Console.Write("Ввелите трехзначное число: ");
    Number = Convert.ToInt32(Console.ReadLine()); 
    if (Number <=100)
    {
        Console.WriteLine("Это не трехзначное число");
    }
    else
    {
        int Digit = (Number % 100) / 10;
        Console.WriteLine($"Вторая цифра числа {Number} - {Digit}");
    }
}
