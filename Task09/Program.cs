// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int number = new Random().Next(10, 100);
// Console.WriteLine($"Случайное число из отрезка 10 - 99 => {number}");
// int firstDigit = number / 10;
// int secondDigit = number % 10;
// if(firstDigit == secondDigit) System.Console.WriteLine("Цифры равны");
// else if(firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа {number} = {firstDigit}");
// else Console.WriteLine($"Наибольшая цифра числа {number} = {secondDigit}");

//через функцию
int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    // if (firstDigit > secondDigit) return firstDigit;
    // return secondDigit;
    if(firstDigit == secondDigit) return 0;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}

int number = new Random().Next(10, 100);
int maxDigit = MaxDigit (number);
string result = maxDigit > 0 ? maxDigit.ToString() : "Цифры равны";
Console.WriteLine($"Наибольшая цифра числа {number} = {result}");

