// 3. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число 
// кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

int a = new Random().Next(10, 51);
int b = new Random().Next(1, 11);
Console.WriteLine(a);
Console.WriteLine(b);
void isItMultipleOrNot(int num1, int num2)
{
    if (num1 % num2 == 0)
    {
        Console.WriteLine(num1 + " is a multiple of " + num2);
    }
    else
    {
        int remainder = num1 % num2;
        Console.WriteLine(num1 + " is not a multiple of " + num2);
        Console.Write("The remainder is ");
        Console.WriteLine(remainder);
    }
}
isItMultipleOrNot(a, b);