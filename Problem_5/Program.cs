// 5. Напишите программу, которая принимает на вход два числа 
// и проверяет, является ли одно число квадратом другого.
// * добавила вывод, в случае если "кто-то кому-то квадрат", 
// то какое число какому "приходится" квадратом (первое второму или второе первому).

int a = 4;
int b = 17;

void AreTheySquares(int num1, int num2)
{
    if (num1 == num2 * num2 | num2 == num1 * num1)
    {
        if (num1 == num2 * num2)
        {
            Console.WriteLine(num1 + " is the square of " + num2);
        }
        else
        {
            Console.WriteLine(num2 + " is the square of " + num1);
        }
    }
    else
    {
        Console.WriteLine("Neither " + num1 + " is the square of " + num2 + ", nor " + num2 + " is the square of " + num1 + ".");
    }
}
AreTheySquares(a, b);