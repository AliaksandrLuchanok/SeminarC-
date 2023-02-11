// Напишите программу, которая на вход принимает число
// и выдаёт является ли число чётным 
Console.WriteLine ("Enter your number");
int number = Convert.ToInt32(Console.ReadLine());
if (number%2 == 0)
{Console.WriteLine($"Your number {number} is even");}
else
{Console.WriteLine($"Your number {number} is not even");}
 