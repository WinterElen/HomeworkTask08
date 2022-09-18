Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num == num % 2)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}