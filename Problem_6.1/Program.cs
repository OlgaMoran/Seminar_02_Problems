// Напишите метод, который принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

int a = new Random().Next(100, 1000);
Console.WriteLine(a);
Console.ReadLine();

void SecondDig_3FigNum(int number)
{
    number = number / 10 % 10;
    Console.Write("Second digit of the number is ");
    Console.WriteLine(number);
}
SecondDig_3FigNum(a);
