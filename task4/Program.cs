// Напишите команду, которая на ввод принимает три числа
// и выдаёт максимальное число

Console.WriteLine("Enter firstNumber");
int N1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter secondNumber");
int N2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter thirdNumber");
int N3 = Convert.ToInt32(Console.ReadLine());
int maxN = N1;
if(maxN < N2) // Смысла дополнительной проверки на равенство нет, чтобы исключить заход в тело if и ресурсы сэкономить
{maxN = N2;}
if (maxN < N3)
{maxN = N3;}
Console.WriteLine($"Maximum value = {maxN}");
