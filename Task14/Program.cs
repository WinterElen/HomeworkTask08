// Console.WriteLine("Введите первое число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if(number % 7 == 0 && number % 23 == 0) Console.WriteLine($"{number}, кратно");
// else Console.WriteLine($"{number}, не кратно");

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool IsAliqut(int arg)
{
    return arg % 7 == 0 && arg % 23 == 0;
}
 if (IsAliqut(number)) Console.WriteLine("Да!");
 else Console.WriteLine("Нет!");
 
