// // Напишите программу, которая на входе принимает число N,
// а на выходе показывает все четные числа от 1 до N

Console.Write("Enter your number=");
int number = Convert.ToInt32(Console.ReadLine());
int count = 2;
if (number>1) // Исключаем значения, не входящие в параметры диапазона проверки
{   Console.WriteLine("Your array of even numbers:");
    while(number>= count)
    { Console.Write($"{count} ");
    count +=2;}
}
else {Console.WriteLine($"Your number {number} is outside the validation parameters or is equale to one");}