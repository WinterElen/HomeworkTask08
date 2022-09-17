Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int square = num2 * num2;
if (num1 == square)
{
    Console.WriteLine("Првое чило является квадратом второго");
}
else
{
    Console.WriteLine("Первое число не является квадратом второго");
}