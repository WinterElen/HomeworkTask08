Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;
if (num2 > num1) 
if (num2 > num3)
{
  Console.WriteLine($"max = {num2}");
}
if (num3 > num2) 
if (num3 > num1)
{
    Console.WriteLine($"max = {num3}"); 
}
if (num1 > num2)
if (num1 > num3)
{
    Console.WriteLine($"max = {num1}");
}