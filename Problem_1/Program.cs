// 1. Напишите метод, который выводит случайное число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.

int a = new Random().Next(10, 100);
Console.WriteLine(a);

void MaxDigitOf2(int number)
{
    int dig1 = number / 10;
    int dig2 = number % 10;
    if (dig1 > dig2)
    {
        Console.Write("max = ");
        Console.WriteLine(dig1);
    }
    else
    {
        Console.Write("max = ");
        Console.WriteLine(dig2);
    }
}
MaxDigitOf2(a);