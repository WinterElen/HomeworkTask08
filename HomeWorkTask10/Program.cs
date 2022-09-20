Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int ShowSecondDigit (int num)
{
    int secondDigit = num / 10;
    return secondDigit % 10;
}
int result = ShowSecondDigit(number);
Console.WriteLine($"{result}");