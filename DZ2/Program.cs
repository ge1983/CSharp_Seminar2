// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Ввелите число: ");
int Number = Convert.ToInt32(Console.ReadLine());

int Digit = (Number / 100) % 10;

if (Digit == 0)
{
    Console.WriteLine($"У числа {Number} - нет третьей цифры");
} 
else
{
    Console.WriteLine($"Третья цифра числа {Number} - {Digit}");
}      