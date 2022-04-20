// Напишите метод, который принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

void SecondDig_3FigNum(int num)
{
    num = num / 10 % 10;
    Console.Write("Second digit of this number is " + num + ".");
}
int a = new Random().Next(100, 1000);
Console.WriteLine(a);
SecondDig_3FigNum(a);