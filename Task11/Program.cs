
int number = new Random().Next(100, 1000);
int RemoveSecondDigit (int num)
{
    int thirdDigit = num % 10;
    int firstDigit = num / 100;
    return firstDigit * 10 + thirdDigit;
}
int result = RemoveSecondDigit(number);
Console.WriteLine($"Итоговое число от {number} => {result}");


//int FirstThird(int res)
//{
   // int firstDigit = num / 100;
    //int thirdDigit = num % 10;
    //return firstDigit * 10 + thirdDigit;
//}
//int number = newRandom().Next(100, 1000);
//int result = FirstThird(number);
//Console.Write($"{number}");
