// Напишите команду, которая на ввод принимает два числа
// и выдаёт какое число большее и какое меньшее

Console.WriteLine("Enter firstNumber");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter secondNumber");
int secondNumber = Convert.ToInt32(Console.ReadLine());
if(firstNumber > secondNumber)
{Console.WriteLine($"Greater number is firstNumber {firstNumber} and Smaller number is secondNumber {secondNumber}");}
else if (firstNumber < secondNumber)
{Console.WriteLine($"Greater number is secondNumber {secondNumber} and Smaller number is firstNumber {firstNumber}");}
else 
{Console.WriteLine($"firstNumber number {firstNumber} ==  secondNumber number {secondNumber}");}