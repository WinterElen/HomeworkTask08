
Console.WriteLine("Введите число от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());

bool IsWeekEnd(int arg)
{
    return arg < 6;
}
 if (IsWeekEnd(number)) Console.WriteLine($"{number} -> Нет(");
 else Console.WriteLine($"{number} -> Да!");
